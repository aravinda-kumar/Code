//#include <iostream>
//using namespace std;
//
//class Box
//{
//public:
//	Box(int , int , int);
//	int volume();
//	void show(int vol);
//	~Box();
//private:
//	int length;
//	int width;
//	int height;
//};
//
//int main()
//{
//	Box b1(12,14,25);
//	Box b2(14,18,190);
//	b1.show(b1.volume());
//
//	b2=b1;
//	b2.show(b2.volume());
//
//	Box b3=b2, b4=b3;
//	b3.show(b3.volume());
//	b4.show(b4.volume());
//
//	system("pause");
//	return 0;
//}
//
//Box::Box(int l, int w, int h)
//{
//	length = l;
//	width = w;
//	height = h;
//}
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