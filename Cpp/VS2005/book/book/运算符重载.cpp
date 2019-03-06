//#include <iostream>
//using namespace std;
//
//class Complex
//{
//	/*friend Complex operator+(Complex &c1, Complex &c2);*/
//public:
//	Complex();
//	Complex(int real, int image);
//	/*Complex add(Complex &c);*/
//	void show();
//	Complex operator + (Complex &c);
//private:
//	int real;
//	int image;
//};
//
//int main()
//{
//	Complex c1(3,4),c2(5,-10),c3;
//	// c3=c1+c2;
//	c3=c1.operator +(c2);
//	c3.show();
//
//	system("pause");
//	return 0;
//}
//
//Complex::Complex()
//{
//	this->real = 0;
//	this->image = 0;
//}
//
//Complex::Complex(int real, int image)
//{
//	this->real=real;
//	this->image=image;
//}
//
////Complex Complex::add(Complex &c)
////{
////	Complex c1;
////	c1.real=this->real+c.real;
////	c1.image=this->image+c.image;
////	return c1;
////}
//
//Complex Complex::operator + (Complex &c)
//{
//	Complex c1;
//	c1.real = this->real + c.real;
//	c1.image = this->image + c.image;
//	return c1;
//}
//
//void Complex::show()
//{
//	cout << "(" << real << "," << image << "i)" << endl;
//}
//
////Complex operator+(Complex &c1, Complex &c2)
////{
////	Complex c;
////	c.real = c1.real + c2.real;
////	c.image = c1.image + c2.image;
////	return c;
////}