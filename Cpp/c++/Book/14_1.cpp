//#include <iostream>
//#include <cmath>
//using namespace std;
//
//void root(double a, double b ,double c);
//
//int main()
//{
//	double a, b, c;
//	cout << "输入相应的系数：" << endl;
//	cin >> a >> b >> c;
//	try
//	{	
//		while(a != 0)
//		{
//			root(a, b, c);
//			cout << "输入相应的系数：" << endl;
//			cin >> a >> b >> c;
//		}
//	}
//	catch(double)
//	{
//		cout << "b^2-4ac<0" << endl;
//	}
//	cout << "end" << endl;
//	system("pause");
//	return 0;
//}
//
//void root(double a, double b ,double c)
//{
//	if(b*b-4*a*c < 0) throw a;
//	else
//	{
//		if(b*b-4*a*c == 0)
//			cout << "x1=x2=" << (-b)/2/a << endl;
//		else
//			cout << "x1=" << ((-b)-sqrt(b*b-4*a*c))/2/a << ", x2=" << ((-b)+sqrt(b*b-4*a*c))/2/a << endl;
//	}
//}