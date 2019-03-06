//#include <iostream>
//using namespace std;
//
//class Box
//{
//public:
//	Box(int , int);
//	int volume();
//	void show(int vol);
//	~Box();
//	static int length;
//	int width;
//	int height;
//};
//
//int Box::length=10;
//
//int main()
//{
//	Box b1(15,20),b2(20,30);
//
//	cout << b1.length << endl;
//	cout << b2.length << endl;
//	cout << Box::length << endl;
//	cout << b1.volume() << endl;
//	
//	b2.length=20;
//	cout << b1.length << endl;
//	cout << b2.length << endl;
//
//	system("pause");
//	return 0;
//}
//
//Box::Box(int w, int h)
//{
//	width = w;
//	height = h;
//}
//
//
//
//Box::~Box()
//{
//	cout <<"Terminated" <<endl;
//}
//
//int Box::volume()
//{
//	return length*width*height;
//}
//
//void Box::show(int vol)
//{
//	cout <<"The volume is:" << vol << endl;
//}