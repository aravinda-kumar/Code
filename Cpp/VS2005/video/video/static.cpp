//#include <iostream>
//using namespace std;
//
//class Cstu
//{
//public:
//	static int a;		//静态成员类外初始化;
//	static const int b = 1;	//只有静态常量整型数据成员才可以在类中初始化
//	
//	static void fun()	//静态函数只可以调用静态变量
//	{
//		cout << "I am static" << endl;
//	}
//
//	Cstu()
//	{
//		a = 11;
//	}
//};
//
//int Cstu :: a = 12;		//int前面不可以加static;
//
//int main()
//{
//	cout << Cstu :: a << endl;  //类名作用域调用;
//	Cstu :: fun();
//
//	Cstu st;
//	cout << st.a << endl;		
//	st.fun();
//	system("pause");
//	return 0;
//}