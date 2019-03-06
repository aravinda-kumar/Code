//#include <iostream>
//using namespace std;
///*************************************
//this指针只能在类的函数内使用；
//*************************************/
//class CStu
//{
//public:
//	int a;
//	CStu (int a)
//	{
//		this -> a = a;   //this = &CStu;
//		this -> show();	 //this指针不是成员，是类成员函数的隐含参数；
//	}
//
//	void show()
//	{
//		cout << a << endl;
//	}
//
//	CStu* GetAddr()
//	{
//		return this;
//	}
//};
//
//int main()
//{
//	CStu st(12);			//对象创建之后生成this指针；
//	st.show();
//	CStu* p = st.GetAddr();
//	cout << p << endl;      
//
//	CStu st1(13);
//	st1.show();
//	CStu* p1 = st.GetAddr();
//	cout << p1 << endl;
//
//	system("pause");
//	return 0;
//}