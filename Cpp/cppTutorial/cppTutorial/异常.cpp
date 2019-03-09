//#include <iostream>
//#include <cstdlib>
//using namespace std;
//
//class CPeople
//{
//public:
//	int ab;
//	CPeople()
//	{
//		ab = 12;
//	}
//};
//
//void fun(int a)
//{
//	if (a == 0)
//	{
//		abort();
//	}
//}
//
//void fun1(int a)
//{
//	while (a < 10)
//	{
//		if (5 == a)
//		{
//			throw 'a';
//		}
//		a++;
//		cout << "a=" << a << endl;
//	}
//}
//
//void fun2(CPeople cp)
//{
//	while (cp.ab < 20)
//	{
//		if (10 == cp.ab)
//		{
//			throw &cp;
//		}
//		cp.ab--;
//	}
//}
//
//int main()
//{
//	CPeople cp;
//	try
//	{
//		fun2(cp);
//	}
//	catch(CPeople &cp)
//	{
//		cout << "out b=" << cp.ab << endl;
//	}
//	catch (CPeople *cp)
//	{
//		cout << "out ch=" << cp->ab << endl;
//	}
//	catch (...)
//	{
//		cout << "error" << endl;
//	}
//
//	system("pause");
//	return 0;
//}