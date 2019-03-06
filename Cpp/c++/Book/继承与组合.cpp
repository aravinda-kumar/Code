//#include <iostream>
//#include <string>
//using namespace std;
//
//class Teacher
//{
//public: 
//	Teacher(string name, int num, char sex);
//	void show_t();
//private:
//	string name;
//	int num;
//	char sex;
//};
//
//class Birthday
//{
//public:
//	Birthday(int year, int month, int day);
//	int year;
//	int month;
//	int day;
//};
//
//
//class Professor:public Teacher
//{
//	friend Birthday;
//public:
//	Professor(string name, int num, char sex, int year, int month, int day):Teacher(name, num, sex),birth(year, month, day){}
//	void show();
//private:
//	Birthday birth;
//};
//
//int main()
//{
//	Professor p1("zhushuai", 1001, 'm', 2018, 8, 3);
//	p1.show();
//
//	system("pause");
//	return 0;
//}
//
//Teacher::Teacher(string name, int num, char sex)
//{
//	this->name = name;
//	this->num = num;
//	this->sex = sex;
//}
//
//void Teacher::show_t()
//{
//	cout << "name:" << name << endl;
//	cout << "num:" << num << endl;
//	cout << "sex:" << sex << endl;
//}
//
//void Professor::show()
//{
//	show_t();
//	cout << "year:" << birth.year << endl;
//	cout << "month:" << birth.month << endl;
//	cout << "day:" << birth.day << endl;
//}
//
//Birthday::Birthday(int year, int month, int day)
//{
//	this->year = year;
//	this->month = month;
//	this->day = day;
//}