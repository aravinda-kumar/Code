//#include <iostream>
//using namespace std;
//
//class Array
//{
//	friend Array operator+(Array &a1, Array &a2);
//	friend ostream& operator<<(ostream& cout, Array &a);
//	friend istream& operator>>(istream& cin, Array &a);
//public:
//	Array();
//	Array(int (*p)[3]);
//private:
//	int ar[2][3];
//};
//
//int main()
//{
//	Array a;
//	int a1[2][3]={1,2,3,4,5,6};
//	Array b(a1);
//	cout << a;
//	cout << b;
//	
//	cout << "********************" << endl;
//
//	cin >> a;
//	cout << a;
//
//	Array c;
//	c=a+b;
//	cout << c;
//
//	system("pause");
//	return 0;
//}
//
//
//Array::Array()
//{
//	int i_countx,i_county;
//	for(i_countx=0;i_countx<2;i_countx++)
//		for(i_county=0;i_county<3;i_county++)
//			*(*(ar+i_countx)+i_county)=0;
//}
//
//Array::Array(int (*p)[3])
//{
//	int i_countx,i_county;
//	for(i_countx=0;i_countx<2;i_countx++)
//	{
//		for(i_county=0;i_county<3;i_county++)
//			ar[i_countx][i_county]=*(*(p+i_countx)+i_county);
//	}
//}
//
//ostream& operator<<(ostream& cout, Array &a)
//{
//	int i_countx,i_county;
//	for(i_countx=0;i_countx<2;i_countx++)
//	{	
//		for(i_county=0;i_county<3;i_county++)
//			cout << *(*(a.ar+i_countx)+i_county) << ' ';
//		cout << endl;
//	}
//	return cout;
//}
//
//istream& operator>>(istream& cin, Array &a)
//{
//	int i_countx,i_county;
//	for(i_countx=0;i_countx<2;i_countx++)
//		for(i_county=0;i_county<3;i_county++)
//			cin >> *(*(a.ar+i_countx)+i_county);
//	return cin;
//}
//
//Array operator+(Array &a1, Array &a2)
//{
//	Array a3;
//	int i_countx, i_county;
//	for(i_countx=0;i_countx<2;i_countx++)
//		for(i_county=0;i_county<3;i_county++)
//			*(*(a3.ar+i_countx)+i_county)=*(*(a1.ar+i_countx)+i_county)+*(*(a2.ar+i_countx)+i_county);
//	return a3;
//}