//#include <iostream>
//using namespace std;
//
//class Cstu
//{
//public:
//	int a;
//	int b;
//	int c;
//	double d;
//
//	int nError;
//
//	Cstu()
//	{
//		a = 12;
//		b = 23;
//		c = 34;
//		d = 45; 
//		nError = -1;
//	}
//
//	void* operator [](int n)
//	{
//		switch(n)
//		{
//		case 0: return &a;
//		case 1: return &d;
//		}
//		return &nError;
//	}
//};
//
//
//
//int main()
//{
//	int a[10] = {1 ,2 ,3};
//	Cstu st;
//	st[1] = 14;
//	cout << *(double *)st[1];
//	*(double *)st[1] = 15;
//	cout << *(double *)st[1];
//	system("pause");
//	return 0;
//}