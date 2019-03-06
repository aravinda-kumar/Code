//#include <iostream>
//using namespace std;
//
//class Complex
//{
//	friend ostream& operator<<(ostream& cout, Complex &c1);
//public:
//	Complex();
//	Complex(int real, int image);
//	Complex(double d);
//	operator double();
//private:
//	int real;
//	int image;
//};
//
//int main()
//{
//	Complex c1(1,2);
//	Complex c2;
//	//double d;
//	c2=c1+1.5;
//	cout << c2 << endl;
//
//	system("pause");
//	return 0;
//}
//
//Complex::Complex()
//{
//	this->real=0;
//	this->image=0;
//}
//
//Complex::Complex(int real, int image)
//{
//	this->real=real;
//	this->image=image;
//}
//
//Complex::Complex(double d)
//{
//	this->real = int(d);
//	this->image=0;
//}
//
//Complex::operator double()
//{
//	return this->real;
//}
//
//ostream& operator<<(ostream& cout, Complex &c1)
//{
//	cout << "(" << c1.real << ", " << c1.image <<"i)";
//	return cout;
//}