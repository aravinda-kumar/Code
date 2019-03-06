//#include <iostream>
//using namespace std;
//
//class time
//{
//public:
//	time(int a,int b):minute(a),sec(b){}
//	void show();
//	friend time operator ++ (time &t);
//private:
//	int minute;
//	int sec;
//};
//
//void time :: show()
//{
//	cout << minute << ":" << sec << endl;
//}
//
//time operator ++ (time &t)
//{
//	if(++t.sec>=60)
//	{
//		t.sec = t.sec -60;
//		t.minute = t.minute + 1;
//	}
//	return t;
//}
//
//int main()
//{
//	time t1(20,0);
//	int i;
//	for(i=0;i<61;i++)
//	{
//		++ t1;
//		t1.show();
//	}
//	system("pause");
//	return 0;
//}