//#include <iostream>
//using namespace std;
//
//class Time
//{
//public:
//	Time();
//	Time(int hour, int minute, int second);
//	void display();
//	void operator++(int);
//private:
//	int hour;
//	int minute;
//	int second;
//};
//
//int main()
//{
//	Time t1,t2(12,13,44);
//	t1.display();
//	t2.display();
//	
//	for(int i_countx=0;i_countx<20;i_countx++)
//	{
//		t2++;
//		t2.display();
//	}
//
//	system("pause");
//	return 0;
//}
//
//Time::Time()
//{
//	hour=0;
//	minute=0;
//	second=0;
//}
//
//Time::Time(int hour, int minute, int second)
//{
//	this->hour=hour;
//	this->minute=minute;
//	this->second=second;
//}
//
//void Time::display()
//{
//	cout << hour << ":" << minute << ":" << second << endl;
//}
//
//void Time::operator++(int)
//{
//	this->second++;
//	if(this->second==60)
//	{
//		this->second=0;
//		this->minute++;
//	}
//}