//#include <iostream>
//using namespace std;
//
//void fun1();
//void fun2();
//void fun3()throw(double);
//
//int main()
//{
//	try
//	{
//		fun1();
//	}
//	catch (double)
//	{
//		cout << "ERROR0!" << endl;
//	}
//	cout << "end0" << endl;
//
//	system("pause");
//	return 0;
//}
//
//void fun1()
//{
//	try
//	{
//		fun2();
//	}
//	catch(char)
//	{
//		cout << "ERROR1!" << endl;
//	}
//	cout << "end1" << endl;
//}
//
//void fun2()
//{
//	try
//	{
//		fun3();
//	}
//	catch(int)
//	{
//		cout << "ERROR2!" << endl;
//	}
//	cout << "end2" << endl;
//}
//
//void fun3() throw(double)
//{
//	double a = 0;
//	try
//	{
//		throw a;
//	}
//	catch(double)
//	{
//		cout << "ERROR3!" << endl;
//		throw;
//	}
//	cout << "end3" << endl;
//}