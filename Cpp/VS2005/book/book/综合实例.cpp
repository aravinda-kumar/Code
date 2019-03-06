//#include <iostream>
//using namespace std;
//
//class Shape
//{
//public:
//	virtual float area()const {return 0.0;}
//	virtual float volume()const{return 0.0;}
//	virtual void shapName()=0;
//};
//
//class Point:public Shape
//{
//	friend ostream& operator<<(ostream &cout, Point p);
//public:
//	Point(float x=0, float y=0);
//	virtual void shapName();
//	void setPoint(float x, float y);
//	float getX()const;
//	float getY()const;
//protected:
//	float x;
//	float y;
//};
//
//class Circle:public Point
//{
//	friend ostream& operator<<(ostream &cout, Circle c);
//public:
//	Circle(float x=0, float y=0, float r=0);
//	virtual float area() const;
//	void setRadius(float r);
//	float getRadius()const;
//	virtual void shapName();
//protected:
//	float radius;
//};
//
//class Cylinder:public Circle
//{
//	friend ostream& operator<<(ostream &cout, Cylinder c);
//public:
//	Cylinder(float x=0, float y=0, float r=0, float h=0);
//	virtual float area()const;
//	virtual float volume()const;
//	virtual void shapName();
//	void setHeight(float h);
//	float getHeight()const;
//protected:
//	float height;
//};
//
//int main()
//{
//	Point point(3.2, 4.5);
//	Circle circle(2.4, 1.2, 5.6);
//	Cylinder cylinder(3.5, 6.4, 5.2, 10.5);
//
//	point.shapName();
//	cout << point;
//
//	circle.shapName();
//	cout << circle;
//
//	cylinder.shapName();
//	cout << cylinder;
//
//	Shape *pt;
//	pt = &point;
//	pt->shapName();
//	cout << "x=" << point.getX() << " ,y=" << point.getY() << "\narea=" << pt->area()
//		<< "\nvolume=" << pt->volume() << "\n\n";
//	
//	pt = &circle;
//	pt->shapName();
//	cout << "x=" << circle.getX() << " ,y=" << circle.getY() << ", r=" << circle.getRadius() << "\narea=" << pt->area()
//		<< "\nvolume=" << pt->volume() << "\n\n";
//
//	pt = &cylinder;
//	pt->shapName();
//	cout << "x=" << cylinder.getX() << " ,cylinder=" << cylinder.getY() << " ,r=" << cylinder.getRadius() << " ,h=" << cylinder.getHeight() << "\narea=" << pt->area()
//		<< "\nvolume=" << pt->volume() << "\n\n";
//
//	system("pause");
//	return 0;
//}
//
//Point::Point(float x, float y)
//{
//	this->x=x;
//	this->y=y;
//}
//void Point::shapName()
//{
//	cout << "\nPoint:" << endl;
//}
//
//void Point::setPoint(float x, float y)
//{
//	this->x = x;
//	this->y = y;
//}
//
//float Point::getX()const
//{
//	return x;
//}
//
//float Point::getY()const
//{
//	return y;
//}
//
//ostream& operator<<(ostream &cout, Point p)
//{
//	cout << "[" << p.x << ", " << p.y << "]" << endl;
//	return cout;
//}
//
//
//Circle::Circle(float x, float y, float r):Point(x, y)
//{
//	this->radius = r;
//}
//
//float Circle::area() const
//{
//	return 3.14159*radius*radius;
//}
//
//void Circle::setRadius(float r)
//{
//	this->radius = r;
//}
//
//float Circle::getRadius()const
//{
//	return radius;
//}
//
//void Circle::shapName()
//{
//	cout << "\nCircle:" << endl;
//}
//
//ostream& operator<<(ostream &cout, Circle c)
//{
//	cout << "[" << c.x << ", " << c.y << "], r=" << c.radius << endl;
//	return cout;
//}
//
//Cylinder::Cylinder(float x, float y, float r, float h):Circle(x, y, r)
//{
//	this->height = h;
//}
//
//float Cylinder::area()const
//{
//	return Circle::area()*2+2*3.14159*radius*height;
//}
//
//float Cylinder::volume()const
//{
//	return Circle::area()*height;
//}
//
//void Cylinder::shapName()
//{
//	cout << "\nCylinder:" << endl;
//}
//
//void Cylinder::setHeight(float h)
//{
//	this->height = h;
//}
//
//float Cylinder::getHeight()const
//{
//	return height;
//}
//
//ostream& operator<<(ostream &cout, Cylinder c)
//{
//	cout << "[" << c.x << ", " << c.y << "], r=" << c.radius << ", h=" << c.height << endl;
//	return cout;
//}