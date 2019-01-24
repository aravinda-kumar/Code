# const相关用法
- [参考文献](https://www.cnblogs.com/Forever-Kenlen-Ja/p/3776991.html)
## const修饰变量
- 普通const用法
  - 代码如下：
  	```cpp
    	int main()
        {
        	const int a = 12;
            return 0;
        }
  	```
  - const常量在定义时必须需要初始化
  - const常量不许进行赋值操作
  - const int a = 12 同 int const a = 12 等价
  - 通过强制类型转化试图改变const变量的值，代码如下
  	```cpp
    int main()
    {
    	const int a = 12;
        // int *pt = &a;
        // [error]普通指针不可以指向常变量
        // 可以利用强制类型转换改变
        int *pt = (int *) &a;
        *pt = 13;
        // 编译可以通过
        cout << "*pt=" << *pt << endl; 	// *pt = 13
		cout << "pt=" << pt << endl;	// pt = 0118FA94
		cout << "a=" << a << endl;		// a = 12
		cout << "&a=" << &a << endl;	// &a = 0118FA94
        return 0;
    }
    ```
  - 利用 *pt = 13之后，a的值在内存中改变为13，但是对编译器而言，a为常变量，所以a的值不会输出时不会发生改变
  - 对于上述情况如果想改变a的值，可以在const之前加上volatile
  - 如：volatile const int a = 13;
  - 这种类型的定义只可以通过指针改变，其本身的值仍然不可以改变
- 指向常对象的指针
	- 代码如下：
	```cpp
    int main()
    {
		int i = 10;
        int j = 20;
        int *pt = &i;
        *pt = 11;
        const int *cpt = &i;
        *cpt = 11;
        // [error]指向常对象的指针不能通过解引用改变对象的值
        cpt = &j;
        // [right]cpt的指向可以发生改变
        return 0;
    }
    ```
    - 指向常对象的指针在其作用域中不可以改变指向的对象的值，但是其本身的指向是可以发生改变的。
    - const int \*cp = int const \*cp
    - 指向常对象的指针可以不进行初始化
    - 指向常对象的指针可以进行赋值操作
    - 此种类型由于const在*号的左侧，所以称为左定值
- 常指针
	- 代码如下:
		```cpp
        int main()
        {
        	int i = 10;
            int j = 20;
            int *const pt = &i;
            *pt = 11;
            // [right]指向的对象的值可以通过指针对象改变
            pt = &j;
            // [error]常指针的指向不可以发生改变
            return 0;
        }
        ```
    - 常指针必须进行初始化
    - 常指针不可以进行赋值操作
    - 常指针可以改变指向的变量的值，但是其本身的指向不可以发生改变
    - 常指针不能指向常对象
    - 此种类型由于const在*号的右侧，所以称为右定值
- 指向常对象的常指针
	- 代码如下：
		```cpp
        int main()
        {
        	int i = 10;
            int j = 20;
            const int *const cpt = &i;
            *cpt = 11;
            // [error]指向常对象的常指针不可以改变变量的值
            cpt = &j;
            // [error]指向常对象的常指针不可以改变指向
            return 0;
        }
        ```
    - 指向常对象的常指针必须进行初始化
    - 指向常对象的常指针不可以进行赋值操作，所以该指针的指向不可以发生改变
    - 指向常对象的常指针不可以通过解引用改变变量的值
    - 左右定值，值和指向均不可变
    - const int \*const pt = &i 和 int const \*const pt = &i 等价
- 指向常对象的指针，常指针和指向常对象的常指针统称为const指针
- const指针可以指向const变量和非const变量，非const指针不可以指向const变量
- 顶层const
	- 常指针称为顶层const
	- int const a = 12 也称为顶层const
- 底层const
	- 指向常对象的指针称为底层const
	- 所有引用均为底层const
## const修饰函数
### const修饰函数参数
- const修饰普通函数参数
	- 代码如下
		```cpp
        void func(const int a)
        {
        	// a++;
            [error] 变量a是常变量，所以即使是在调用函数中也不可以改变变量值
            cout << a << endl;
            return 0;
        }
        ```
    - 对于函数列表中定义为常变量的参数，在函数体中不可以改变常变量的值
    - 常变量的参数可以让非const变量传递进来
- 函数参数为const指针
	- 注意*和++的优先级
	- *p++的意思是p指针地址加一后再解引用，而不是p地址指向的内容加一
	- 基本特性和const指针完全一样

### const修饰函数返回值
- const修饰普通返回值
	- 作用和普通返回值一样，值可以发生改变
## const引用
- 常引用
	- 代码如下
		```cpp
        int main()
        {
        	int i = 20;
            const int &ri1 = i;
            int const &ri2 = i;
            cout << ri1 << ' ' << ri2 << endl;
            return 0;
        }
        ```
    - const int &ri1 = i 和 int const &ri2 = i 等价
    - const引用可以修饰普通变量和const变量，但普通变量只可以修饰普通变量不可以修饰const变量
    - 常引用必须直接初始化，不可以进行赋值操作
    - 常引用可以直接用常数赋值
    - 代码如下
    	```cpp
    	int main()
    	{
    		const int &rb1 = 100;
        	int const &rb2 = 200;
            return 0;
    	}
    	```
    - 代码等价于
    	```cpp
        int main()
        {
        	const int tmp = 100;
            const int &rb1 = tmp;
            return 0;
        }
        ```
- 常引用传递函数参数中时，特性同常引用类似

# constexpr用法(常量表达式)
- 定义：在编译器编译的时候系统就可以确定变量为常量表达式
- constexpr不可以进行赋值操作
- 所有constexpr变量均为常量，所以必须使用常量表达式对constexpr进行初始化，但不可以用返回值时const的函数对其初始化
- 可以利用const变量对constexpr变量初始化
- const变量的初始化可以延时到运行时，但constexpr变量的初始化必须在编译时进行
- constexpr int mf = 0; // 0是常量表达式
- constexpr int limit = mf + 1; // mf + 1 是常量表达式
- constexpr int sz = size(); 当size()是一个constexpr函数时，sz才正确
- constexpr函数
	- 需用用到该函数的代码的时候，编译器在编译的时候就计算出返回值的函数
- 引用，指针与constexpr
	- constexpr指针的初始化必须是nullptr，0或者是一个固定的地址的对象
	```cpp
    int main()
    {
    	constexpr int *pt = nullptr;
        static int a = 12;
        constexpr int *pt1 = &a;
        (*pt1)++;
        // [right] pt1的指向不可以改变，但是值可以发生改变
        cout << *pt1 << endl; *pt1 = 12;
    	return 0;
    }
    ```
    - 定义在所有函数之外的对象可以用constexpr指针或者引用绑定，代码如下：
    ```cpp
    int a = 12;
    int b = 13;
    int main()
    {
    	constexpr int *pt = &a;
        cout << ++(*pt) << endl;
        constexpr int &ci = b;
        cout << ++ci << endl;
    	return 0;
    }
    ```
    - 定义在所有函数之外的对象的地址是固定不变的。
    - 对于指针而言，constexpr仅对指针有效，与指针所指的对象无关
- constexpr指针和const指针的区别
	- 示例代码：
	```cpp
    int a = 12;
    int b = 13;
    int main()
    {
    	const int *pt = &a;
        constexpr int *cpt = &a;
        // (*pt)++;
        // [error]指向常对象的指针不可以改变对象的值
        (*cpt)++;
        // [right]指针常量表达式可以改变对象的值
        pt = &b;
        // [right]指向常对象的指针可以改变指向
        // cpt = &b;
        // [error]指针常量表达式不可以改变指向
        return 0;
    }
    ```
    - const对指针和对象都有一定的影响，具体影响看const所在的位置
    - constexpr仅对指针有效，不可以改变指针指向，可以改变指针指向的对象的属性
    - int const *const a = &i; 功能上等价于 constexpr const int *a = &i;