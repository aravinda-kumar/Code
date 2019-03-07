//#include<iostream>
//using namespace std;
//
//class CStu
//{
//	friend void fun1();
//	friend class CTeach;
//private:
//	int age;
//	void fun()
//	{
//		age = 12;
//		cout << age << endl;
//	}
//};
//
//class CTeach
//{
//public:
//	CStu stu2;
//	void fun2()
//	{
//		stu2.fun();
//	}
//};
//
//void fun1()
//{
//	CStu stu;
//	stu.fun();
//}
//
//int main()
//{
//	
//	CTeach tea;
//	tea.fun2();
//
//	system("pause");
//	return 0;
//}