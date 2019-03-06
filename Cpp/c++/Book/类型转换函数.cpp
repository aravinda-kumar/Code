//#include <iostream>
//using namespace std;
//
//class Complex
//{
//	friend ostream& operator<<(ostream& cout, Complex &c);
//	friend Complex operator+(Complex &c1, Complex &c2);
//public:
//	Complex();
//	Complex(int real, int image);
//	Complex(double d);
//	operator double();
//	// Complex operator+(Complex &c1);
//private:
//	int real;
//	int image;
//};
//
//int main()
//{
//	Complex c1(1,2), c2(3,4),c3;
//	cout << c1 << endl;
//	//double d;
//	//d = c1+2.5;
//	//cout << d << endl;
//	c3=c2+Complex(2.5);
//	c3=2.5+c2;
//	cout << c3 << endl;
//
//	cout << c3 << endl;
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
//ostream& operator<<(ostream& cout, Complex &c)
//{
//	cout << "(" << c.real << ", " << c.image << "i)";
//	return cout;
//}
//
//Complex::operator double()
//{
//	return this->real;
//}
//
//Complex::Complex(double d)
//{
//	this->real=d;
//	this->image=0;
//}
//
////Complex Complex::operator+(Complex &c1)
////{
////	return Complex(this->real+c1.real, this->image+c1.image);
////}
//
//Complex operator+(Complex &c1, Complex &c2)
//{
//	return Complex(c2.real+c1.real, c2.image+c1.image);
//}