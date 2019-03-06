//#include <iostream>
//using namespace std;
//
//class Time
//{
//public:
//	Time(int h, int m, int s);
//	void show_time();
//	void show_time_1()const;
////private:
//	const int hour;
//	mutable int minute;
//	int second;
//};
//
//int main()
//{
//	const Time t1(12,13,14);
//	//t1.show_time();
//	t1.show_time_1();
//	cout << t1.second << endl;
//	Time t2(14,15,15);
//	t2.show_time_1();
//	
//	system("pause");
//	return 0;
//}
//
//Time::Time(int h, int m, int s):hour(h)
//{
//	
//	minute = m;
//	second = s;
//}
//
//void Time::show_time()
//{
//	cout << "Time is:" << hour << ":" << minute << ":" << second << endl;
//}
//
//void Time::show_time_1()const	
//{
//	cout << "Time is:" << hour+1 << ":" << ++minute << ":" << second+1 << endl;
//}