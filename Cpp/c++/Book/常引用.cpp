//#include <iostream>
//using namespace std;
//
//class Time
//{
//public:
//	Time(int, int, int);
//	void show_time();
//	int hour;
//	int minute;
//	int second;
//};
//
//void fun(const Time &t);
//
//int main()
//{
//	Time t1(12,13,14);
//	t1.show_time();
//	int *p;
//	p=new int [10];
//	cout << *p << endl;
//	delete []p;
//	fun(t1);
//	t1.show_time();
//
//	system("pause");
//	return 0;
//}
//
//Time::Time(int h, int m, int s)
//{
//	hour = h;
//	minute = m;
//	second = s;
//}
//
//void Time::show_time()
//{
//	cout << hour << ":" << minute << ":" << second << endl;
//}
//
//void fun(const Time &t)
//{
//	cout << "unchangable!" << endl;
//}