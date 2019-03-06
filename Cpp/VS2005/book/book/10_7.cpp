//#include <iostream>
//#include <string>
//using namespace std;
//
//class Teacher;
//
//class Student
//{
//	friend ostream& operator<<(ostream& cout, Student &s);
//public: 
//	Student(string name, int number, char sex);
//	Student(Teacher &t);
//private:
//	string name;
//	int number;
//	char sex;
//};
//
//class Teacher
//{
//	friend Student;
//public:
//	Teacher(string name, int number, char sex);
//private:
//	string name;
//	int number;
//	char sex;
//};
//
//int main()
//{
//	Student s1("zhushuai", 1001, 'm');
//	Teacher t1("johnson", 1002, 'f');
//
//	cout << s1 << endl;
//	
//	s1=Student(t1);
//	cout << s1 << endl;
//
//	system("pause");
//	return 0;
//}
//
//Student::Student(string name, int number, char sex)
//{
//	this->name=name;
//	this->number=number;
//	this->sex=sex;
//}
//
//Student::Student(Teacher &t)
//{
//	this->name=t.name;
//	this->number=t.number;
//	this->sex=t.sex;
//}
//
//Teacher::Teacher(string name, int number, char sex)
//{
//	this->name=name;
//	this->number=number;
//	this->sex=sex;
//}
//
//ostream& operator<<(ostream& cout, Student &s)
//{
//	cout << s.name << ' ' << s.number << ' ' << s.sex;
//	return cout;
//}