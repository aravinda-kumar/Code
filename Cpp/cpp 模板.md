# cpp 模板

- 函数模板
	- 意义 -- 模板是泛型编程的一种重要思想
	- 写法
	```cpp
	template <typename T> //用class代替typename也是可以的
	void fun(T a)
	{
		//T的类型取决于a
	}
	```
	- 格式
		- template <typename T>
		- template <class T>
		- 可以有多个参数 -- template <typename T1, typename T2>
		- 作用域 -- 仅对下面挨着的代码段有效
	- 具体化
		- 就是将制定的类型单独处理
		- template<> void fun<Node>(Node no);
		- 具体化的模板的优先级是要高于普通模板的
		- 普通函数的优先级也要高于有模板的函数
	- 实例化
		- 生成指定类型的函数定义
		- template void fun<int>(int a);
		- 生成一个参数是int的函数定义
- 类模板
	- template<typename T>
	  class CFather{};
	- 可以设定默认值，此时定义时尖括号里面可以不写内容，但是尖括号必须要有，有默认值的默认放在右边
		- template<typename T=int>
	- **只有类模板可以设定默认值**
	- 穿件对象传递模板参数列表，类型后面增加<>表名类型
		- CFather<int> pf(12);
	- 除了类定义，其他任意位置出现类名都要加上参数列表
	- 类外实现类模板函数成员的写法
		```cpp
		template<typename T>	//类外部的模板声明不加默认值参数 -- 类似于默认值参数
		void CFather<T>::Show()
		{
			//func_body
		}
		```
- 继承的模板
```cpp
#include<iostream>
using namespace std;

template<typename T1, typename T2=int>
class CFather
{
public:
	T1 a;
	CFather(T1 a)
	{
		this->a = 12;
	}
	void Show()
	{
		cout << a << endl;
	}
};

template<typename T1, typename T2>	//此处可以不指定类型参数的默认值
class CSon :public CFather<T1, T2>	//父类要指定参数列表
{
public:
	CSon(T1 a):CFather<T1, T2>(a)	//构造处也要指定
	{

	}
};

int main()
{
	CSon<int, string> son(12);
	son.Show();

	CSon<int, int> *pson = new CSon<int, int>(123);
	pson->Show();

	system("pause");
	return 0;
}
```
- 多态的模板
	- 子类没模板
		- CFather<int, int >*pf = new CSon;
	- 子类有模板
		- CFather<int, int >*pf = new CSon<int, int>;
```cpp
#include<iostream>
using namespace std;

template <typename T1, typename T2>
class CFather
{
public:
	virtual void fun()
	{
		cout << "CFather" << endl;
	}
};

//参数列表要显式声明
//template <typename T1, typename T2>
class CSon :public CFather<int, int>
{
public:
	void fun()
	{
		cout << "CSon" << endl;
	}
};

int main()
{
	//参数列表要相同
	CFather<int, int> *pf = new CSon;
	pf->fun();

	system("pause");
	return 0;
}
```
- 类型参数是类的模板
	- 参数类型一定要匹配
```cpp
#include<iostream>
using namespace std;

template <typename T>
class CAA
{
public:
	int a;
};

template <typename T1>
class CFather
{
public:
	CFather(CAA<T1> &a)
	{

	}
	void fun()
	{
		cout << "CFather" << endl;
	}
};

int main()
{
	CAA<char> a;
	CFather<char> pf(a);

	system("pause");
	return 0;
}
```
