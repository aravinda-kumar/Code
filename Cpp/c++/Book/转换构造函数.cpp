//#include <iostream>
//#include <string>
//using namespace std;
//
//class Teacher;
//
//class Student
//{
//	friend ostream& operator<<(ostream &cout, Student &s);
//public:
//	Student();
//	Student(string name, char sex, int age, int score);
//	Student(Teacher &t);
//private:
//	string name;
//	char sex;
//	int age;
//	int score;
//};
//
//class Teacher
//{
//	friend Student;
//public:
//	Teacher();
//	Teacher(string name, char sex, int age, int number);
//private:
//	string name;
//	char sex;
//	int age;
//	int number;
//};
//
//int main()
//{
//	Student s1;
//	Teacher t1("zhushuai",'M',24,1001);
//	cout << s1;
//	s1=Student(t1);
//	cout << s1;
//
//	system("pause");
//	return 0;
//}
//
//Student::Student()
//{
//	this->name="default";
//	this->sex='M';
//	this->age=0;
//	this->score=0;
//}
//
//Student::Student(string name, char sex, int age, int score)
//{
//	this->name=name;
//	this->sex=sex;
//	this->age=age;
//	this->score=score;
//}
//
//Student::Student(Teacher &t)
//{
//	this->name=t.name;
//	this->sex=t.sex;
//	this->age=t.age;
//	this->score=t.number;
//}
//
//Teacher::Teacher()
//{
//	this->name="default";
//	this->sex='M';
//	this->age=0;
//	this->number=0;
//}
//
//Teacher::Teacher(string name, char sex, int age, int number)
//{
//	this->name=name;
//	this->sex=sex;
//	this->age=age;
//	this->number=number;
//}
//
//ostream& operator<<(ostream &cout, Student &s)
//{
//	cout << s.name<< ' ' << s.sex << ' ' << s.age << ' ' << s.score << endl;
//	return cout;
//}