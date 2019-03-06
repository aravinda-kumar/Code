//#include <iostream>
//using namespace std;
//
//class Time
//{
//public:
//	Time(int h, int m, int s):hour(h),minute(m),second(s){};
//	
//private:
//	friend void show_time(Time &t);
//	// 无访问权限
//	int hour;
//	int minute;
//	int second;
//};
//
//int main()
//{
//	Time t1(12,13,14);
//	show_time(t1);
//
//	system("pause");
//	return 0;
//}
//
//void show_time(Time &t)
//{
//	cout << t.hour << ":" << t.minute << ":" << t.second << endl;
//}