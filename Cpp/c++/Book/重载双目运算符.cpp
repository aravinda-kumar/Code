//#include <iostream>
//using namespace std;
//
//class String
//{
//	friend bool operator>(String str1, String str2);
//	friend bool operator<(String str1, String str2);
//	friend bool operator==(String str1, String str2);
//	friend void compare(String str1, String str2);
//public:
//	String(){p=NULL;}
//	String(char *str);
//	void display();
//private:
//	char *p;
//};
//
//int main()
//{
//	String str1("zhushuai"),str2("johnson");
//	compare(str1, str2);
//
//	system("pause");
//	return 0;
//}
//
//String::String(char *str)
//{
//	p=str;
//}
//
//void String::display()
//{
//	cout << p;
//}
//
//bool operator>(String str1, String str2)
//{
//	bool result=false;
//	// string is not a pointer, so we need to call it's menber;
//	if(strcmp(str1.p, str2.p)>0)
//		result=true;
//	return result;
//}
//
//bool operator<(String str1, String str2)
//{
//	bool result=false;
//	// string is not a pointer, so we need to call it's menber;
//	if(strcmp(str1.p, str2.p)<0)
//		result=true;
//	return result;
//}
//
//bool operator==(String str1, String str2)
//{
//	bool result=false;
//	// string is not a pointer, so we need to call it's menber;
//	if(strcmp(str1.p, str2.p)==0)
//		result=true;
//	return result;
//}
//
//void compare(String str1, String str2)
//{
//	if(str1>str2)
//		cout << str1.p << ">" << str2.p << endl;
//	if(str1<str2)
//		cout << str1.p << "<" << str2.p << endl;
//	if(str1==str2)
//		cout << str1.p << "==" << str2.p << endl;
//}