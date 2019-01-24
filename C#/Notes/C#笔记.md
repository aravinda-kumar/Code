# C#笔记
1. 字面值的默认类型
       整数默认为int类型
       小数默认为double类型
2. 指数类型例如1e10为double类型
3. 在string类型中@可以忽略后面的字符串中的转移字符的作用
4. 字符的不可变性
	```cs
	string str = "abc";
    str.ToUpper();
    Console.WriteLine(str);
    //out: abc
	```
    ```cs
    string str = "abc";
    str = str.ToUpper();
    Console.WriteLine(str);
    //or Console.WriteLine(str.ToUpper());
    //out: ABC
    ```
    ToUpper()方法具有返回值，但是在执行过程中不会改变本来的字符串的值，如果相对数据进行更改，需要对变量名称进行重新赋值。
5. string和stringBuilger
- string在需要大量进行重复操作字符串时候耗时较长
- stringBuilder相比于string速度会有明显提升
	```cs
	using System.Diagnostics;
    Stopwatch timer = new Stopwatch();
	timer.Start();
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < 1000; i++)
    	sb.Append(i.ToString());
	Console.WriteLine(timer.ElapsedMilliseconds);
    timer.Stop();
    //out:近似0
	```
    ```cs
    using System.Diagnostics;
    Stopwatch timer = new Stopwatch();
	timer.Start();
	string str = string.Empty;
	for (int i = 0; i < 10000; i++)
    	str += i.ToString();
    Console.WriteLine(timer.ElapsedMilliseconds);
    timer.Stop();
    //out:69ms
    ```
6. 可空修饰符
	```cs
    //int num = null;
    //error;
    //null 不可以转换成 int
	int? num = null;
    Console.WriteLine(num);
    //out:无字符显示
    ```
7. 数据转换
- 显式转换--由高到低
 	```cs
    long a = 1;
    int b = 2;
    b = (int)a;
    ```
    这种情况下有可能出现数据的溢出
    ```cs
    int a = int.MaxValue;
    a = a + 1;
    Console.WriteLine(a);
    //out:-2147483648
    ```
    为了避免这种情况为程序带来的危害，使用checked语句块
    ```cs
    checked
    {
    	int a = int.MaxValue;
    	a = a + 1;
    	Console.WriteLine(a);
    }
    //out:抛出数据溢出异常
    ```
- 隐式转换--由低到高
 	```cs
    long a = 1;
    int b = 2;
    a = b;
    ```
    ```cs
    int b = int.MaxValue;
    long a = b;
    a = a + 1;
    Console.WriteLine(a);
    //out:2147483648
    ```
- 函数转换
	- Parse():将数字形式的字符串转换成字面值与之等价的32位整形，功能类似python中的int()函数
 		```cs
        var str1 = Console.ReadLine();
        var str2 = Console.ReadLine();
        int a1 = int.Parse(str1);
        int a2 = int.Parse(str2);
        Console.WriteLine(a1 + a2);
        // in: "1"  "2"
        // out: 3
        ```
	- TryParse():int的静态成员函数，如果输入的数字则返回true，否则返回false
	- ToString()：数据类型的普通成员函数。
8. 三元运算符？：嵌套使用
	```cs
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    var d = (a > b ? a : b) > c ? (a > b ? a : b) : c;
    ```
9. 空接合运算符
	```cs
    string fileName = null;
    fileName = fileName??"DefaultName.txt";
    //如果fileName中是空返回DefaultName.txt，不是空则返回本来的内容
    ```
10. 预处理指令
	```cs
	#region sum
	double sum = 0;
	for (double i = 1; i < 100; i++)
		sum += i / (i + 1);
	Console.WriteLine(sum);
	#endregion
	```
	没有实际的意义，只是在阅读代码时可以压缩代码块。
11. 类中的非static函数可以调用任意函数，static函数只可以调用static函数
12. C#中为什么Main()函数需要设置为static?
	假设没有static关键字,那意味着需要用生成一个实例后才可以调用这个Ｍain方法,而Ｍain方法是程序入口点，你没有进入Ｍain方法,自然无法生成一个实例,既然没有实例，那就无法调用Ｍain函数，岂不矛盾?所以Ｍain函数被设置为static.
13. ref是为基本类型设计，然而由于string的不可变性，所以在函数中无法直接更改字符串，所以需要使用ref来为string类型进行重新赋值。
14. 上下文关键字：只在特定的条件下才是关键字
	```cs
	class Test
	{
		private string _Name;
		public Name
		{
			get{return _Name;}
			set{_Name = value;}
		}
	}
	class Program
	{
		static void Main()
		{
			int value;
		}
	}
	```
	如上文所示，在Main函数中可以定义名为value的变量，但是是set{}里面value就有特定的含义。
15. 对象初始化器： object obj = new object(){Name = "xxxx"};
	匿名对象：var user = new{Name = "xxx", age = 0};
16. 静态构造函数只有类第一次实例化的时候才会被调用。
17. readonly只能在声明、构造函数中赋值。
18. virtual：只可以被继承，不可以被实例化。即可用于类，也可用于方法。
	sealed：只可以被实例化，不可以被继承。即可用于类，也可用于方法。
19. this：对应本类
	base：对应基类
20. 可以将派生类基类转换
	```cs
	class Animal
	{
		public string Name{get; set;}
	}
	class Dog:Animal
	{}
	...
	static void Main()
	{
		Animal ani = new Animal();
		Dog dog = new Dog();
		dog.Name = "123";
		ani = dog;
		Console.WriteLine(ani.Name);
	}
	//out: 123;
	```
21. 多态的核心`virtual-override`,一个基类多种状态。
22. override和new的区别，override在原址上进行覆写，new是开辟新的区域重新创建方法。
23. is 用作类型判断`if(class1 is class2)`
	as 用作类型转换`class1 as class2`
24. abstract和virtual
	abstract类无法实例化
	abstract方法必须包含在abstract类中
	abstract的方法可以没有主体，virtual方法必须要有主体，即使主体为空；
	virtual可以被子类重写,abstract必须被子类重写
	virtual只可以修饰方法
25. interface目的是解决多继承的问题，用法几乎和类继承相同
	interface是一系列方法、属性的集合
	interface的访问修饰符都是fly
26. C#中class和struct的默认访问修饰符是private
	interface和enum的默认访问修饰符是public
27. struct和enum是值类型
28. try1/catvh\*/finally1
	异常捕获和抛出的异常最贴切的一个异常
	```cs
	try{throw new InvalidCastException();}
	catch(InvalidCastException ex){}
	catch(FieldAccessException ex){}
	catch(Exception ex){}
	finally{}
	```
	在上面的例子中程序抛出InvalidCastException异常之后由第一个catch捕获，虽然所有的异常都是继承自Exception，但异常的捕获只捕获和抛出异常最贴切的一个，所以不执行Exception的异常操作。
29. 泛型的约束：为了使用特定的方法，所以对泛型进行类型约束
30. 运算符重载：static public bool operator !=(Location loc1, Location loc2)
	有一些特定的操作符是不可以被重载的
31. 一个解决方案下的一个项目就是一个程序集。
32. 委托和多播委托
	```cs
	delegate bool Function(int num);
	......
	Function func1 = new Function(isEven);
	func1 -= isEven;			//退订
	func1 += isGreaterThan10;	//订阅
	```
33. 系统自定义委托
	- Action：封装一个方法，该方法只有一个参数并且没有返回值; 后面更有委托变量名
	- Func< int, bool>:封装一个方法，该方法有一定的参数，并有一个输出参数(out);
34. 发送者-订阅者模型-以报社送报纸为例---以接口类型实现
	- 受众可能出现：个人、公司、政府机关...
	- 受众规定有共同的行为：收报纸、读报纸
	- 对于报社来说，无论是个人、公司、政府机关，本质上并没有区别，它们都是subscribers，所以只需要执行一种操作即可。
	- 但是对于个人、公司、政府机关来说，它们进行收取报纸和读报纸的行为是存在区别的，所以不能以一个统一的函数来实现。
	- 所以此时需要先把个人、公司、政府机关的行为抽象成一个interface，在interface中规定了个人、公司、政府机关有哪些共同的行为，在分别在个人、公司、政府机关中实现这些行为。
		```cs
		interface INewspaer
    	{
			//任何订阅者都会具有收报纸和读报纸两种行为
        	void SetNewspaper(Newspaper newspaper);
        	void ReadNewspaper();
    	}
		class Company:INewspaer
    	{
        	public string Name { get; set; }
			public Newspaper newspaper { get; set; }
			public Company(string Name)
			{
				this.Name = Name;
			}
			//公司实现了读报纸和收报纸的行为
        	public void ReadNewspaper()
        	{
            	Console.WriteLine($"{this.Name} is reading newspaper, title is {this.newspaper.Title}, content is {this.newspaper.Content}");
        	}
        	public void SetNewspaper(Newspaper newspaper)
        	{
            	this.newspaper = newspaper;
        	}
    	}
		class Person : INewspaer
		{
			public Person(string Name)
			{
				this.Name = Name;
			}
			string Name { get; set; }
			public Newspaper newspaper { get; set; }
			//个人实现了读报纸和收报纸的行为
			public void SetNewspaper(Newspaper newspaper)
			{
				this.newspaper = newspaper;
			}
			public void ReadNewspaper()
			{
				Console.WriteLine($"{this.Name} is reading newspaper, title is {this.newspaper.Title}, content is {this.newspaper.Content}");
			}
		}
		class Publisher
		{
			public Publisher(string Name)
			{
				this.Name = Name;
			}
			string Name { get; set; }
			//可以直接把对象传入接口的集合中
			public List<INewspaer> Subscribers = new List<INewspaer>();
			public void SendNewspaper(Newspaper newspaper)
			{
				foreach(var item in Subscribers)
				{
					item.SetNewspaper(newspaper);
				}
			}
		}
		Main()
		{
            var publisher = new Publisher("chubansheX");
			//设置个人订阅者
            var A = new Person("A");
            var B = new Person("B");
			//设置公司订阅者
            var C1 = new Company("C1");
            var C2 = new Company("C2");
			//为出版社添加订阅者
            publisher.Subscribers.Add(A);
            publisher.Subscribers.Add(B);
  	        publisher.Subscribers.Add(C1);
            publisher.Subscribers.Add(C2);
            publisher.SendNewspaper(new Newspaper() { Title = "biaoti", Content = "neirong" });
            A.ReadNewspaper();
            C1.ReadNewspaper();
		}
		```
35. 如下语法可以将多播委托单个执行
	```cs
	foreach (Action\<Newspaper> handler in subscribers.GetInvocationList())
	//其中subscribers是多播委托
	```
36. 扩展方法
	用静态类和静态方法去扩展已经封闭分类代码
37. 