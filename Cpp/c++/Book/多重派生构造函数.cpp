//#include <iostream>
//#include <string>
//using namespace std;
//
//class Person
//{
//public:
//	Person();
//	Person(string name, char sex);
//	~Person();
//	void display();
//protected:
//	string name;
//	char sex;
//};
//
//class Student:public Person
//{
//public:
//	Student(int num);
//	~Student();
//	void show();
//private:
//	int num;
//};
//
//class Senior:private Student
//{
//public:
//	Senior(int num, double score);
//	~Senior();
//	void show_s();
//private:
//	double score;
//};
//
//int main()
//{
//	//Senior s1("zhushuai", 'm', 1001, 90);
//	Senior s1(1001, 90);
//	s1.show_s();
//
//	system("pause");
//	return 0;
//}
//
//Person::Person()
//{
//	this->name="johnson";
//	this->sex='m';
//}
//
//Person::Person(string name, char sex)
//{
//	this->name = name;
//	this->sex = sex;
//}
//
//Person::~Person()
//{
//	cout << "基类的析构函数" << endl;
//}
//
//void Person::display()
//{
//	cout << "name:" << name << endl;
//	cout << "sex:" << sex << endl;
//}
//
////Student::Student(string name, char sex, int num):Person(name, sex)
//Student::Student(int num)
//{
//	this->num = num;
//}
//
//void Student::show()
//{
//	display();
//	cout << "num:" << num << endl;
//}
//
//Student::~Student()
//{
//	cout << "子类1的析构函数" << endl;
//}
//
////Senior::Senior(string name, char sex, int num, double score):Student(name, sex, num)
//Senior::Senior(int num, double score):Student(num)
//{
//	this->score=score;
//}
//
//Senior::~Senior()
//{
//	cout << "子类2的析构函数" << endl;
//}
//
//void Senior::show_s()
//{
//	show();
//	cout << "score:" << score << endl;
//}