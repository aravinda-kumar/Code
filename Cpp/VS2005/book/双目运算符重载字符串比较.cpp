//#include <iostream>
//#include <cstring>
//using namespace std;
//
//class String
//{
//public:
//	String():p(NULL){}
//	String(char *ptr):p(ptr){}
//	void show();
//	friend bool operator < (String &s1,String &s2);
//	friend void compare(String &s1,String &s2);
//private:
//	char *p;
//};
//
//void String :: show()
//{
//	cout << p ;
//}
//
//bool operator < (String &s1,String &s2)
//{
//	bool c;
//	if(strcmp(s1.p ,s2.p)<0)
//		c = 1;
//	else c = 0;
//	return c;
//}
//
//void compare(String &s1,String &s2)
//{
//	if(operator < (s1 ,s2) == 1)
//	{
//		s1.show(); cout << "<";  s2.show();
//		cout << endl;
//	}
//	if(operator < (s1 ,s2) == 0)
//	{
//		s1.show(); cout << ">";  s2.show();
//		cout << endl;
//	}
//}
//
//int main()
//{
//	String a("book"),b("Hello");
//	a.show();
//	cout << endl;
//	cout << "**********************" << endl;
//	b.show();
//	cout << endl;
//	cout << (a < b) << endl;
//	compare (a ,b);
//	system("pause");
//	return 0;
//}