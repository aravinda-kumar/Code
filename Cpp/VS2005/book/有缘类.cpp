//#include <iostream>
//using namespace std;
//
//class Date;
//class time
//{
//public:
//	time(int a=12 ,int b=23 ,int c=34):hour(a),minute(b),sec(c){}
//	void show()
//	{
//		cout << "The time is :" << hour << ":" << minute << ":" << sec << endl;
//	}
//	friend class Date;
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
//	void show()
//	{
//		cout << "The date is :" << year << "/" << month << "/" << day << endl;
//	}
//	time t1;
//	void show1()
//	{t1.show();}
//private:
//	int year;
//	int month;
//	int day;
//};
//
//int main()
//{
//	time t1;
//	Date d1;
//	d1.show1();
//	system("pause");
//	return 0;
//}