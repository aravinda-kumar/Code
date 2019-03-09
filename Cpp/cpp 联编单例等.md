# cpp 其他

- 联编 -- 函数定义和函数调用连接的过程
	- 将模块或者函数合并在一起生成可执行代码的处理过程，(函数调用)，按照联编锁进行的阶段不同，可分为两种不同的联编方法：静态联编和动态联编。
	- 静态联编
		- 指编译阶段就将函数实现和函数调用关联起来
			- 普通的函数调用就属于静态联编
	- 动态联编
		- 是指程序执行的时候才将函数实现和函数调用关联
		- 动态联编是针对C++多态的，C语言里面全是静态联编
- 单例 -- 一个类只能创建一个对象
	- 关键点
		- 构造函数成为私有的或者受保护的
		- 通过静态成员函数申请对象空间，并返回地址
		- 定义一个静态标记，记录对象的个数，并控制
		- 析构函数将标记清空，以达到重复申请对象的目的
	- 构造函数是私有的类，该类就不能被实例化，运行时报错，编译时可以被正常通过。
- 异常
	- 是认为定义的一种状况
	- abort()
		- 弹出异常终止框
	- try catch throw
		- try -- 用来检测异常，try后面一定要跟catch
		- throw -- 代码块中出现异常用throw抛出，throw的出现代表程序的结束
		- catch -- 处理异常的方式，不可以出现两种一样的catch
			- catch(...) -- 接收所有异常
		- 抛出对象的时候，要用引用或者指针，不然会调用拷贝构造函数
- 内部类
	- 内部类访问外部类
		- 内部类中访问外部类成员需要先定义外部类的对象
	- 外部类访问内部类
		- 外部内访问内部类的成员也要使用内部类的对象
	```cpp
	class COut
	{
	public:
		int a;
		COut() :in(this)
		{
			a = 12;
		}
	public:
		class CIn
		{
		public:
			int b;
			COut *out;
			CIn(COut *pf)
			{
				out = pf;
				b = 13;
			}
			void funin()
			{
				//COut out;
				cout << out->a << endl;
			}
		};
	public:
		CIn in; //需要的是初始化，所以使用初始化列表赋值，声明必须放在内部类的定义后面
	};

	COut ou;
	ou.a = 15;
	ou.in.funin();
	//out；15
	```
- 类型转换
	- 旧式类型转换
		- (type)数据
		- type(数据)
	- 新式类型转换
		- static_cast
			- 当type和expression可以相互隐式类型转换的时候，这个方法执行起来才是合法的
			- 如：基类子类之间互相转换没问题，如果跟一个不相干的类一起转换就会出问题
			- 形式 static_cast <type>(expression)
		- const_cast
			- 类型转换掉表达式的const和volatile属性，**仅当type和expression一样的时候才合法**
			- 注意：转指针与非转指针，非指针要传地址或者引用
			- 形式
				- const_cast<type>(expression)
		- dynamic_cast
			- 特点
				- expression的类型是type的公有派生类
				- expression和type类型一样
				- expression是type的公有基类
				- 父类和子类(public继承)相互转换的运算符，或者自己转自己
			- 形式
				- dynamic_cast<type>(expression)
			- 注意：父类向子类转换的时候，父类要是多态即父类要有虚函数，子类要重写虚函数
		- reinterpret_cast
			- 用于天生危险的类型转换
			- 形式
				- reinterpret_cast<type>(expression)
			- 注意点
				- 这种转换适用于依赖实现的底层编程技术，代码不可移植，例如不同的系统可能以不同的顺序存储多字节数据中的字节
				- 互相转换时，空间一定要够用，否则不行
				- 函数指针和数据指针不能相互转换