//#include <iostream>
//#include "base.h"
//#include "point.h"
//#include "circle.h"
//#include "cylinder.h"
//using namespace std;
//
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