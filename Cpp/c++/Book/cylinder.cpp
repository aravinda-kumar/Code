//#include "cylinder.h"
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