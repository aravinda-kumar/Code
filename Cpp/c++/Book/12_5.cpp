//#include <iostream>
//using namespace std;
//
//class Shape
//{
//public:
//	virtual void shapeName()=0;
//	virtual double shapeArea()=0;
//	virtual void showArea()=0;
//};
//
//class Circle:public Shape
//{
//public:
//	Circle(double r);
//	virtual void shapeName();
//	virtual double shapeArea();
//	virtual void showArea();
//protected:
//	double radius;
//};
//
//class Square:public Shape
//{
//public:
//	Square(double x);
//	virtual void shapeName();
//	virtual double shapeArea();
//	virtual void showArea();
//protected:
//	double x;
//};
//
//class Rectangle:public Shape
//{
//public:
//	Rectangle(double x, double y);
//	virtual void shapeName();
//	virtual double shapeArea();
//	virtual void showArea();
//protected:
//	double x;
//	double y;
//};
//
//class Trapezoid:public Shape
//{
//public:
//	Trapezoid(double x, double y, double h);
//	virtual void shapeName();
//	virtual double shapeArea();
//	virtual void showArea();
//protected:
//	double x;
//	double y;
//	double h;
//};
//
//class Triangle:public Shape
//{
//public:
//	Triangle(double x, double h);
//	virtual void shapeName();
//	virtual double shapeArea();
//	virtual void showArea();
//protected:
//	double x;
//	double h;
//};
//
//
//int main()
//{
//	Circle circle(2);
//	Square square(3);
//	Rectangle rectangle(4,5);
//	Trapezoid trapezoid(6, 7, 8);
//	Triangle triangle(9, 10);
//
//	static double add=0;
//	Shape *pt;
//
//	pt = &circle;
//	pt->shapeName();
//	pt->showArea();
//	add += pt->shapeArea();
//
//	pt = &square;
//	pt->shapeName();
//	pt->showArea();
//	add += pt->shapeArea();
//
//	pt = &rectangle;
//	pt->shapeName();
//	pt->showArea();
//	add += pt->shapeArea();
//
//	pt = &trapezoid;
//	pt->shapeName();
//	pt->showArea();
//	add += pt->shapeArea();
//
//	pt = &triangle;
//	pt->shapeName();
//	pt->showArea();
//	add += pt->shapeArea();
//
//	cout << "all area is:" << add << endl;
//
//	system("pause");
//	return 0;
//}
//
//Circle::Circle(double r)
//{
//	this->radius = r;
//}
//
//void Circle::shapeName()
//{
//	cout << "Circle:" << endl;
//}
//
//double Circle::shapeArea()
//{
//	return 3.14159*radius*radius;
//}
//
//void Circle::showArea()
//{
//	cout << "Area is:" << shapeArea() << endl;
//}
//
//Square::Square(double x)
//{
//	this->x = x;
//}
//
//void Square::shapeName()
//{
//	cout << "Square:" << endl;
//}
//
//double Square::shapeArea()
//{
//	return x*x;
//}
//
//void Square::showArea()
//{
//	cout << "Area is:" << shapeArea() << endl;
//}
//
//
//Rectangle::Rectangle(double x, double y)
//{
//	this->x = x;
//	this->y = y;
//}
//
//void Rectangle::shapeName()
//{
//	cout << "Rectangle:" << endl;
//}
//
//double Rectangle::shapeArea()
//{
//	return x*y;
//}
//
//void Rectangle::showArea()
//{
//	cout << "Area is:" << shapeArea() << endl;
//}
//
//Trapezoid::Trapezoid(double x, double y, double h)
//{
//	this->x = x;
//	this->y = y;
//	this->h = h;
//}
//
//void Trapezoid::shapeName()
//{
//	cout << "Trapezoid:" << endl;
//}
//
//double Trapezoid::shapeArea()
//{
//	return (x+y)*h/2.0;
//}
//
//void Trapezoid::showArea()
//{
//	cout << "Area is:" << shapeArea() << endl;
//}
//
//Triangle::Triangle(double x, double h)
//{
//	this->x = x;
//	this->h = h;
//}
//
//void Triangle::shapeName()
//{
//	cout << "Triangle:" << endl;
//}
//
//double Triangle::shapeArea()
//{
//	return x*h/2.0;
//}
//
//void Triangle::showArea()
//{
//	cout << "Area is:" << shapeArea() << endl;
//}