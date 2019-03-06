//#include <iostream>
//using namespace std;
//
//class Cstu
//{
//public:
//	Cstu() 		//构造函数和析构函数不能为常函数；
//	{
//		a = 12;
//	}
//
//	~Cstu() //Cstu* this;
//	{
//
//	}
//	int a;
//
//	void show() const //const Cstu* this;
//	{
//		//a = 13;  //常函数不能修改数据成员；
//		int b = 12; //常函数内部可以定义数据成员并且可以修改
//		cout << "I am show!" << endl;
//		cout << a*12 << endl; //常函数中可以操作数据成员
//	}
//
//	void fun()
//	{
//		cout << "I am fun!" << endl;
//	}
//};
//
//int main()
//{
//	Cstu st;		//普通对象既可以调用常函数也可以调用普通函数；
//	st.show();
//	st.fun();
//
//	const Cstu st1;	//常对象只能调用常函数；
//	st1.show();
//
//	system("pause");
//	return 0;
//}