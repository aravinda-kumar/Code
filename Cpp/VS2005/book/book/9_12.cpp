//#include <iostream>
//using namespace std;
//
//template <class numtype>
//class Date;
//template <class numtype>
//class Time;
//template <class numtype>
//void display(Time<numtype> &t, Date<numtype> &d);
//
//template <class numtype>
//class Time
//{
//	friend void display<numtype>(Time<numtype> &t, Date<numtype> &d);
//public:
//	Time(numtype hour, numtype minute, numtype second);
//private:
//	numtype hour;
//	numtype minute;
//	numtype second;
//};
//
//template <class numtype>
//class Date
//{
//	friend void display<numtype>(Time<numtype> &t, Date<numtype> &d);
//public:
//	Date(numtype year, numtype month, numtype day);
//private:
//	numtype year;
//	numtype month;
//	numtype day;
//};
//
//int main()
//{
//	Time<int> t1(12,13,14);
//	Date<int> d1(2018,7,31);
//
//	display(t1, d1);
//
//	system("pause");
//	return 0;
//}
//
//template <class numtype>
//Time<numtype>::Time(numtype hour, numtype minute, numtype second)
//{
//	this->hour = hour;
//	this->minute = minute;
//	this->second = second;
//}
//
//template <class numtype>
//Date<numtype>::Date(numtype year, numtype month, numtype day)
//{
//	this->year=year;
//	this->month=month;
//	this->day=day;
//}
//
//template <class numtype>
//void display(Time<numtype> &t, Date<numtype> &d)
//{
//	cout << d.year << "/" << d.month << "/" << d.day << endl;
//	cout << t.hour << ":" << t.minute << ":" << t.second << endl;
//}