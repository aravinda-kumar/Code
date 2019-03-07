//#include<iostream>
//using namespace std;
//
//class CStu
//{
//public:
//	int a;
//	CStu(int a)
//	{
//		this->a = a;
//		//a=a
//		//这个a是参数a，覆盖了外部的a，所以并么有给外部a初始化
//	}
//	CStu* GetAddr()
//	{
//		return this;
//	}
//	void show()
//	{
//		cout << a << endl;
//	}
//};
//
//int main()
//{
//	CStu st(12);
//	st.show(); 
//	cout << st.GetAddr() << endl;
//
//	system("pause");
//	return 0;
//}