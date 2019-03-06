//#include <iostream>
//using namespace std;
//
//class Box
//{
//public:
//	Box(int , int , int);
//	void volume();
//	void show();
//	~Box();
//private:
//	int length;
//	int width;
//	int height;
//	int vol;
//};
//
//int main()
//{
//	Box *pt;
//	pt = new Box(12, 13, 14);
//	pt->volume();
//	pt->show();
//	delete pt;
//
//	pt = new Box(15, 16, 17);
//	pt->volume();
//	pt->show();
//	delete pt;
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
//void Box::volume()
//{
//	vol =length*width*height;
//}
//
//void Box::show()
//{
//	cout <<"The volume is:" << vol << endl;
//}