//#include<iostream>
//using namespace std;
//
//class CFather
//{
//public:
//	int a;
//	virtual void fun()
//	{
//
//	}
//};
//
//class CSon :public CFather
//{
//public:
//	int b;
//	void fun()
//	{
//
//	}
//};
//
//
//int main()
//{
//	CFather *pf = new CFather;
//	CSon * p1 = dynamic_cast<CSon *>(pf);
//
//	CSon *ps = new CSon;
//	CFather *pf1 = dynamic_cast<CFather *>(ps);
//
//	int a = 12;
//	double b = 12.12;
//	a = static_cast<int>(b);
//	cout << a << endl;
//
//	system("pause");
//	return 0;
//}