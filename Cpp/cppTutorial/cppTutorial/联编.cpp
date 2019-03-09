//#include <iostream>
//using namespace std;
//
//class CA
//{
//public:
//	virtual void fun()
//	{
//		cout << "this is CA" << endl;
//	}
//};
//
//class CB :public CA
//{
//public:
//	void fun()
//	{
//		cout << "this is CB" << endl;
//	}
//};
//
//int main()
//{
//	//CA a;
//	//a.fun();
//
//	CA *ca = new CB;
//	ca->fun();
//
//	int b;
//	cin >> b;
//	switch (b)
//	{
//		case 1: ca = new CA; break;
//		case 2: ca = new CB; break;
//		default:break;
//	}
//	ca->fun();
//
//	system("pause");
//	return 0;
//}