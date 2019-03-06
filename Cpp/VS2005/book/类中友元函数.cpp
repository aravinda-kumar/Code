//#include <iostream>
//using namespace std;
//
//class Date;
//class time
//{
//public:
//	time(int a=12 ,int b=23 ,int c=34):hour(a),minute(b),sec(c){}
//	void display(Date &t);
//////	void display()
////	{
////		cout << "The date is :" << t.year << "/" << t.month << "/" << t.day << endl;
////		cout << "The time is :" << hour << ":" << minute << ":" << sec << endl;
////	}
//	void show()
//	{
//		cout << "The time is :" << hour << ":" << minute << ":" << sec << endl;
//	}
//private:
//	int hour;
//	int minute;
//	int sec;
//};
//
//class Date
//{
//public:
//	Date(int a=2017 ,int b=2 ,int c=6):year(a),month(b),day(c){}
//	friend void time :: display(Date &t);
//	void show()
//	{
//		cout << "The date is :" << year << "/" << month << "/" << day << endl;
//	}
//private:
//	int year;
//	int month;
//	int day;
//};
//
//void time :: display(Date &t)
//{
//	cout << "The date is :" << t.year << "/" << t.month << "/" << t.day << endl;
//	cout << "The time is :" << hour << ":" << minute << ":" << sec << endl;
//}
//
//int main()
//{
//	time t1;
//	Date d1;
//	t1.display(d1);
////	t1.show();
////	d1.show();
//	system("pause");
//	return 0;
//}