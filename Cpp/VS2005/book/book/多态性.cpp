//#include <iostream>
//using namespace std;
//
//class Point
//{
//	friend ostream& operator<< (ostream &cout, const Point &p);
//public:
//	Point(float x=0, float y=0);
//	void setPoint(float x, float y);
//	float getX() const;
//	float getY() const;
//protected:
//	float x, y;
//};
//
//class Circle:public Point
//{
//	friend ostream& operator<<(ostream &cout, const Circle &c);
//public:
//	Circle(float x=0, float y=0, float r=0);
//	void setRadius(float r);
//	float getRadius() const;
//	float area() const;
//protected:
//	float radius;
//};
//
//class Cylinder:public Circle
//{
//	friend ostream& operator<< (ostream &cout, const Cylinder &c);
//public:
//	Cylinder(float x=0, float y=0, float r=0, float h=0);
//	void setHeight(float h);
//	float getHeight() const;
//	float area() const;
//	float volume() const;
//protected:
//	float height;
//};
//
//int main()
//{
//	Point p(3.5, 6.6);
//	cout << "x=" << p.getX() <<",y=" << p.getY() << endl;
//	p.setPoint(8.5, 6.8);
//	cout << p;
//	
//	Circle c(3.5, 6.4, 5.2);
//	cout << c.getX() << "," << c.getY() << "," << c.getRadius() << "," << c.area() << endl;
//	c.setPoint(5,5);
//	c.setRadius(7.5);
//	cout << c;
//	Point &pref=c;
//	cout << pref;
//	
//	Cylinder cy1(3.4, 6.4, 5.2, 10);
//	cout << "original cylinder:\nx = " << cy1.getX() << ", y = " << cy1.getY() << ", r="
//		<< cy1.getRadius() << ", h=" << cy1.getHeight() << "\narea:" << cy1.area()
//		<< ", volume=" << cy1.volume() << endl;
//	cy1.setHeight(15);
//	cy1.setRadius(7.5);
//	cy1.setPoint(5, 5);
//	cout << "\nnew cylinder:\n" << cy1;
//	Point &pref1=cy1;
//	cout << "\npref as a point:" << pref1;
//	Circle &cref=cy1;
//	cout << "\ncref as a circle:" << cref;
//
//	system("pause");
//	return 0;
//}
//
//Point::Point(float x, float y)
//{
//	this->x = x;
//	this->y = y;
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
//
//float Point::getY()const
//{
//	return y;
//}
//
//ostream& operator << (ostream &cout, const Point &p)
//{
//	cout << "[" << p.x << ", " << p.y << "]" << endl;
//	return cout;
//}
//
//Circle::Circle(float x, float y, float r):Point(x, y)
//{
//	this->radius = r;
//}
//
//void Circle::setRadius(float r)
//{
//	this->radius = r;
//}
//
//float Circle::getRadius() const
//{
//	return radius;
//}
//
//float Circle::area() const
//{
//	return 3.14159*radius*radius;
//}
//
//ostream& operator <<(ostream &cout, const Circle &c)
//{
//	cout << "center=[" << c.x << ", " << c.y << "], r=" << c.radius << endl; 
//	return cout;
//}
//
//Cylinder::Cylinder(float x, float y, float r, float h):Circle(x, y, r)
//{
//	this->height = h;
//}
//
//void Cylinder::setHeight(float h)
//{
//	this->height = h;
//}
//
//float Cylinder::getHeight() const
//{
//	return height;
//}
//
//float Cylinder::area() const
//{
//	return Circle::area()*2+2*3.14159*radius*height;
//}
//
//float Cylinder::volume() const
//{
//	return Circle::area()*height;
//}
//
//ostream& operator<< (ostream &cout, const Cylinder &c)
//{
//	cout << "Center=[" << c.x << ", " << c.y << "],r=" << c.radius << "h=" << c.height
//		 << "\narea=" << c.area() << ",volume=" << c.volume() << endl;
//	return cout;
//}