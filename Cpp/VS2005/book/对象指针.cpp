//#include <iostream>
//using namespace std;
//
//class time
//{
//public:
//	time(int a,int b,int c):hour(a),minute(b),sec(c){}
//	void show()
//	{
//		cout << hour << ":" << minute << ":" << sec << endl ;
//	}
//	int hour;
//	int minute;
//	int sec;
//};
//
//int main()
//{
//	time t1(12,23,34);
//	int *p1;
//	p1 = &t1.hour;
//	cout << "t1.hour = " << t1.hour << endl;
//	cout << "*p1 = " << *p1 << endl;
//	void (time :: *p2)();
//	p2 = &time :: show;
//	cout << "t1.show()" << endl;
//	t1.show();
//	cout << "t1.*p2" << endl;
//	(t1.*p2)();
//	time *p3;
//	p3 = & t1;
//	cout << "p3->show()" << endl;
//	p3->show();
//	system("pause");
//	return 0;
//}