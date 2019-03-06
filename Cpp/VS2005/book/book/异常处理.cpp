//#include <iostream>
//#include <cmath>
//using namespace std;
//
//double triangle(double a, double b, double c) throw(double);
//
//int main()
//{
//	double a, b, c;
//	cin >> a >> b >> c;
//	try
//	{
//		while(a>0 && b>0 && c>0)
//		{
//		//try
//		//{
//			cout << triangle(a, b, c) << endl;
//		//}
//		//catch(double)
//		//{
//		//	cout << "a=" << a << ", b=" << b << ", c=" << c << ", that is not a triangle!" << endl;
//		//}
//			cin >> a >> b >> c;
//		}
//	}
//	catch(double)
//	{
//		cout << "a=" << a << ", b=" << b << ", c=" << c << ", that is not a triangle!" << endl;
//	}
//	catch(...)
//	{
//		cout << "ERROR" << endl;
//	}
//	cout << "end" << endl;
//
//	system("pause");
//	return 0;
//}
//
//double triangle(double a, double b, double c)throw(double)
//{
//	if(a+b<=c || b+c <=a || c+a<=b) throw a;
//	double s=(a+b+c)/2;
//	return sqrt(s*(s-a)*(s-b)*(s-c));
//}