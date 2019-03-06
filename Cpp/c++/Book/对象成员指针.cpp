//#include <iostream>
//using namespace std;
//
//class Time
//{
//public:
//	int hour;
//	int minute;
//	int second;
//	Time(int h, int m, int s);
//	void show_time();
//};
//
//int main()
//{
//	Time t1(12, 12, 12);
//	cout << "t1.hour=" << t1.hour << endl;
//	int *p1=&t1.hour;
//	cout << "*p1=" << *p1 << endl;
//
//	Time *pt;
//	pt = & t1;
//	t1.show_time();
//	(*pt).show_time();
//	pt->show_time();
//
//	void (Time::*p2)();
//	p2=&(Time::show_time);
//
//	(t1.*p2)();
//
//	system("pause");
//	return 0;
//}
//
//Time::Time(int h, int m, int s)
//{
//	this->hour=h;
//	this->minute=m;
//	this->second=s;
//}
//
//void Time::show_time()
//{
//	cout << "Time is:" << hour << ":" << minute << ":" << second << endl;
//}