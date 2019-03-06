//#include<iostream>
//using namespace std;
//
//double pnx(int i_x, int i_n);
//
//int main()
//{
//	int i_x, i_n;
//	double d_o;
//	i_x = 2;
//	i_n = 2;
//	d_o = pnx(i_x, i_n);
//	cout << d_o << endl;
//	system("pause");
//	return 0;
//}
//
//double pnx(int i_x, int i_n)
//{
//	double d_x = double(i_x);
//	double d_n = double(i_n);
//	if(d_n == 0)
//		return 1;
//	else
//	{
//		if(d_n == 1)
//			return d_x;
//		else
//			return ((2*d_n-1)*d_x-pnx(d_x, d_n-1)-(d_n-1)*pnx(d_x, d_n-2))/d_n;
//	}
//}