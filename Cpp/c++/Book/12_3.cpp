//#include <iostream>
//using namespace std;
//
//class Point
//{
//public:
//	Point(int x, int y)
//	{
//		this->x=x;
//		this->y=y;
//	}
//	~Point(){cout << "Executing Point destructor!" << endl;}
//protected:
//	int x;
//	int y;
//};
//
//class Circle:public Point
//{
//public:
//	Circle(int x, int y, int z):Point(x, y)
//	{
//		this->z = z;
//	}
//	~Circle(){cout << "Executing Circle destructor!" << endl;}
//protected:
//	int z;
//};
//
//int main()
//{
//	Circle *pt = new Circle(1, 2, 3);
//	delete pt;
//
//	system("pause");
//	return 0;
//}