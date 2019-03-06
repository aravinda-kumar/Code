//#include <iostream>
//using namespace std;
//
//class Time
//{
//private:
//	int hour;
//	int minute;
//	int second;
//public:
//	Time()
//	{
//		hour=0;
//		minute=0;
//		second=0;
//	}
//	void show();
//};
//
//struct Student
//{
//	int a;
//	int b;
//};
//
//class Rect
//{
//public:
//	void show();
//	Rect(int len, int wid=10, int hei=10);
//	~Rect();
//private:
//	int length;
//	int width;
//	int height;
//};
//
//int main()
//{
//	Time t1;
//	t1.show();
//
//	Student stu1={12,12};
//	Student stu2=stu1;
//		
//	Rect r1(12);
//	r1.show();
//
//	Rect r2(15,21,30);
//	r2.show();
//		
//	system("pause");
//	return 0;
//}
//
//void Time::show()
//{
//	cout << hour << ":" << minute << ":" << second << endl;
//}
//
//Rect::Rect(int len, int wid, int hei)
//{
//	length = len;
//	width = wid;
//	height = hei;
//}
//
//void Rect::show()
//{
//	cout << "The vessel is:" << length*width*height << endl;
//}
//
//Rect::~Rect()
//{
//	cout << "Destructor called" << endl;
//}