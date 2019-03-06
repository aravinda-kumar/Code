//#include <iostream>
//using namespace std;
//
//class Complex
//{
//	friend ostream& operator<<(ostream &cout, Complex &c1);
//	friend istream& operator>>(istream &cin, Complex &c1);
//public:
//	Complex();
//	Complex(int real, int image);
//	void display();
//	Complex operator+(Complex &c1);
//private:
//	int real;
//	int image;
//};
//
//int main()
//{
//	Complex c1(1,2), c2(3,4), c3;
//	c3=c1+c2;
//	c3.display();
//	
//	cout << c3;
//
//	cin >> c1 >> c2;
//	cout << c1 << c2;
//	cout << (c1+c2);
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
//void Complex::display()
//{
//	cout << "(" << real << "," << image << "i)" << endl;
//}
//
//Complex Complex::operator+(Complex &c1)
//{
//	Complex c;
//	c.real = this->real+c1.real;
//	c.image = this->image+c1.image;
//	return c;
//}
//
//ostream& operator<<(ostream &cout, Complex &c1)
//{
//	cout << "(" << c1.real << "," << c1.image << "i)" << endl;
//	return cout;
//}
//
//istream& operator>>(istream &cin, Complex &c1)
//{
//	cin >> c1.real >> c1.image;
//	return cin;
//}