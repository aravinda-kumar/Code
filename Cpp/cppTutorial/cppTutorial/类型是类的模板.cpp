//#include<iostream>
//using namespace std;
//
//template <typename T>
//class CAA
//{
//public:
//	int a;
//};
//
//template <typename T1, typename T2>
//class CFather
//{
//public:
//	CFather(CAA<T1> &a)
//	{
//
//	}
//	void fun()
//	{
//		cout << "CFather" << endl;
//	}
//};
//
//class CBase
//{
//public:
//	virtual void fun1()
//	{
//		cout << "CBase void fun1" << endl;
//	}
//	virtual void fun2() = 0;
//};
//
//class CDerive:public CBase
//{
//public:
//	void fun2()
//	{
//		cout << "CDerive void fun2" << endl;
//	}
//};
//
//
//int main()
//{
//	CAA<char> a;
//	CFather<char, CAA<int>> pf(a);
//
//	CBase *cb = new CDerive;
//	//允许调用是因为fun1()被继承到CDerive中了
//	cb->fun1();
//	cb->fun2();
//
//
//	system("pause");
//	return 0;
//}