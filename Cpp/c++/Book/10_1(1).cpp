//#include <iostream>
//using namespace std;
//
//class Complex
//{
//	friend Complex operator+(Complex &c1, Complex &c2);
//	friend Complex operator-(Complex &c1, Complex &c2);
//	friend Complex operator*(Complex &c1, Complex &c2);
//	friend Complex operator/(Complex &c1, Complex &c2);
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
//	Complex c1(1,2), c2(3,4),c3;
//	//c3=c1+c2;
//	//cout << c3 << endl;
//	//c3=c1-c2;
//	//cout << c3 << endl;
//	//c3=c1*c2;
//	//cout << c3 << endl;
//	//c3=c1/c2;
//	//cout << c3 << endl;
//	//c3=c1+Complex(1.5);
//	//cout << c3 << endl;
//	c3=c1+1.5;
//	cout << c3 << endl;
//
//	system("pause");
//	return 0;
//}
//
//Complex::Complex()
//{
//	this->real=real;
//	this->image=image;
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
//	this->real=d;
//	this->image=0;
//}
//
//Complex::operator double()
//{
//	return this->real;
//}
//
//Complex operator+(Complex &c1, Complex &c2)
//{
//	return Complex(c1.real+c2.real, c1.image+c2.image);
//}
//
//Complex operator-(Complex &c1, Complex &c2)
//{
//	return Complex(c1.real-c2.real, c1.image-c2.image);
//}
//
//Complex operator*(Complex &c1, Complex &c2)
//{
//	return Complex(c1.real*c2.real-c1.image*c2.image, c1.real*c2.image+c1.image*c2.real);
//}
//
//Complex operator/(Complex &c1, Complex &c2)
//{
//	return Complex((c1.real*c2.real+c1.image*c2.image)/(c2.real^2-c2.image^2), (c1.image*c2.real-c1.real*c2.image)/(c2.real^2-c2.image^2));
//}
//
//ostream& operator<<(ostream& cout, Complex &c1)
//{
//	cout << "(" << c1.real << ", " << c1.image <<"i)";
//	return cout;
//}