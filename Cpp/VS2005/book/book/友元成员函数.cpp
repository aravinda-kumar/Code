//#include <iostream>
//using namespace std;
//
//class Date;
//
//class Time
//{
//public:
//	Time(int h, int m, int s):hour(h),minute(m),second(s){};
//	void display(Date &t);
//private:
//	int hour;
//	int minute;
//	int second;
//};
//
//class Date
//{
//	friend void Time::display(Date &t);
//public:
//	Date(int y, int m, int d):year(y),month(m),day(d){};
//private:
//	int year;
//	int month;
//	int day;
//};
//
//int main()
//{
//	Time t(12,13,14);
//	Date d(2018,7,31);
//
//	t.display(d);
//
//	system("pause");
//	return 0;
//}
//
//void Time::display(Date &t)
//{
//	cout << t.year << "/" << t.month << "/" << t.day << endl;
//	cout << hour << ":" << minute << ":" << second << endl;
//}