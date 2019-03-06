//#include <iostream>
//using namespace std;
//
////子类中若含有和父类中相同的数据成员，子类的值会覆盖掉父类的数据成员；
////子类中的输出加上父类的作用域还可以调用父类中的数据成员；
//
//class CFather
//{
//public:
//	int a;
//	int b;
//	CFather()
//	{
//		a = 12;
//		b = 13;
//	}
//
//	friend void show();
//
//	void fun(int a)
//	{
//		cout << "CFatherfun()" << endl;
//	}
//};
//
//
//
//class CSon : public CFather
//{
//private:
//	int c;
//public:
//	int a;
//	CSon()
//	{
//		a = 10;
//	}
//
//	void fun()
//	{
//		cout << "CSonfun()" << endl;
//	}
//};
//
////父类的友元函数并不是子类的友元函数；
////友元函数不可以被继承；
//void show()
//{
//	CSon ft;
//	cout << ft.c << endl;
//}
//
//int main()
//{
//	CSon so;
//	so.fun();
//	//so.fun(1); 报错，父类和子类同名但其中有一个有参数的时候，两者不是重载函数；
//	so.CFather :: fun(1);
//	//类外调用同理，需要用类名作用域区分；
//	cout << so.a << endl;
//	cout << so.CFather :: a << endl;
//
//	system("pause");
//	return 0;
//}