# 返回*this和返回void的区别

- 主要代码如下
	```cpp
	class Student
	{
	public:
    	Student()=default;
    	Student(string name, int age);
    	Student &add_age_r();
    	void add_age_v();
    	void show();
	private:
    	string name = "NoName";
    	int age = 0;
	};
	Student& Student::add_age_r()
	{
    	++age;
    	return *this;
	}

	void Student::add_age_v()
	{
    	++age;
	}
    ```
- 有一个Student类如上，其中包含了两个年龄增加函数(即add_age)函数，其中add_age_r函数的返回值时一个引用，add_age_v没有返回值，从功能实现上来讲通过以下的代码都可以实现年龄的增加，并且可以通过内部显示函数将其显示出来
	```cpp
    Student stu("zhushuai", 23);
    stu.add_age_r();
    stu.show();
    
    stu.add_age_v();
    stu.show();
    ```
- 以上两种方式都可以实现功能，且没有什么区别。但是当代码改写为如下方式，两者就有差别了。
	```cpp
    Student stu("zhushuai", 23);
    stu.add_age_r().show();	//Right
    stu.add_age_v().show();	//Error
    ```
- 上述代码的第一种写法仍旧可以正常实现函数功能，但第二种写法就是错误的，原因如下：
	- 由于age_add_r的返回值时应用，且从代码中可以看出，返回的是this指针的解引用，也就是说返回的是调用方法的类的本身，所以调用完stu.add_age_r()后该部分会自动变成stu，所以下一步可以调用stu.show()
	- 但是对于add_age_v来讲，由于函数本身没有返回值，所以stu.add_age_v()调用结束后就消失了，所以无法继续调用show()方法。
	- 返回引用的实现方式类似于cout类，如：
	```cpp
    	cout << 1 << 2 << 3 << endl;
    ```
    - cout 输出1之后的返回值是其本身的引用，所以可以继续输出下一个数字。

## 函数返回本身为何没有数据接收

- 简单参考实例
	```cpp
    int add_2(int a, int b)
    {
    	return a+b;
    }
    ```
- 上述代码是一个简单的加法函数，正常的调用方式如下
	```cpp
    	int a = 1;
        int b = 2;
    	int c = add_2(a, b);
    ```
- 此时加法函数的返回值被数据c接收，这也是比较容易理解的调用方式。
- 但是有些时候为了简化程序代码也会出现如下所述的调用方法：
	```cpp
    	int a = 1;
        int b = 2;
    	cout << add_2(a, b) << endl;
    ```
- 由此可见，如果此时需要直接将加法函数的返回值直接输出，此时则不需要再次定义变量接收返回值，将其直接作为形参传入“输出函数”即可。
- 原因如下：
	- add_2(int a, int b)函数在调用结束后会返回一个整型数据值，所以在实际运行过程中，当加法函数运行结束后，cout << add_2(a, b) << endl; 就会自动变成了，cout << "return的数据" << endl；所以此时并不一定需要有变量对它进行接收，就可以直接使用返回值。
- 因此返回*this的返回在调用后，那一部分将有返回值直接取代，不需要变量接收也可以实现。
- 但如果使用了变量对返回值接收之后再去调用其他函数，这种方式也可以实现函数功能。

## 返回引用和返回普通类型的区别

- 如果再添加一种实现年龄增加的方法，代码如下
	```cpp
    Student add_age()
    {
    	++age;
        return *this;
    }
    ```
- 这种实现方法如果仍然执行语句stu.add_age_r().show();最终的显示效果和age_add_r()的结果并没有区别，但内部数据的处理以及实现方式却有很大的不同。
- add_age_r()方法返回的是引用类型，加之返回值时*this所以，相当于返回的是自身类的引用，所以就是把自身返回。
- 但对于add_age()来说，虽然其返回值仍然是*this。但此时它的返回类型却是Student，即类类型，所以函数的返回值时一个类，也就是说代码可以改写为：
	```cpp
    Student add_age()
    {
    	++age;
        Student stu;
        stu = *this;
        return stu;
    }
    ```
- 从上述代码可以看出，实际上add_age()函数返回的是*this的拷贝，也就是说，该返回值实际上与*this的内容并没有任何的关系，如果后续该返回值的数据成员发生改变，这些改变也不会影响到*this中的数据成员内容。
- 验证代码如下。
	```cpp
    Student stu("zhushuai", 23);
    stu.add_age().add_age().show();	// 年龄是25
    stu.show();						// 年龄是24
    ```
- 通过上述代码可以看出，第二行代码中虽然两次对年龄进行增加，但实际上stu本身的年龄只增加了一次，因为在第一次调用add_age()函数中改变的就是stu中的数据成员age，但第二次调用add_age()函数时改变的age就和stu没有关系了，它只是改变了第一次调用年龄增加函数返回数据中的age成员，所以最后输出stu中的数据成员时，年龄依旧是24。
- 实际上stu.add_age().add_age().show()中show()函数的主体已经是第三个量了，因为第二次调用年龄增加函数后该函数又返回了一个对象。
- 综上所示，返回普通的类型不但不能实现所需要的数据的改变，有可能在多次调用直线实现内存空间的巨大浪费，因为类类型的数据一般都占用比较大的内存空间。
- 所以一般情况下都是使用引用作为返回类型，除非程序中的功能明确表明需要返回普通数据类型。