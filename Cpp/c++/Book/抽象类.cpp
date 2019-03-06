//#include <iostream>
//using namespace std;
//
//class A
//{
//public:
//	virtual void area()=0;
//	virtual void show()=0;
//};
//
//class B:public A
//{
//public:
//	void area(){cout << "This is area in B." << endl;}
//	void show(){cout << "This is show in B." << endl;}
//};
//
//class C:public B
//{
//public:
//	void area(){cout << "This is area in C." << endl;}
//	void show(){cout << "This is show in C." << endl;}
//};
//
//int main()
//{
//	A *pt;
//	B b1;
//	C c1;
//	pt = &b1;
//	pt->area();
//	pt->show();
//	pt = &c1;
//	pt->area();
//	pt->show();
//
//	system("pause");
//	return 0;
//}