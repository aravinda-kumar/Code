//#include <iostream>
//#include <string>
//using namespace std;
//
//class Person
//{
//public:
//	Person(string name, int age, char sex);
//protected:
//	string name;
//	int age;
//	char sex;
//};
//
//class Teacher:virtual public Person
//{
//public:
//	Teacher(string name, int age, char sex, string title);
//protected:
//	string title;
//};
//
//class Student:virtual public Person
//{
//public:
//	Student(string name, int age, char sex, double score);
//protected:
//	double score;
//};
//
//class Graduate:public Teacher, public Student
//{
//public:
//	Graduate(string name, int age, char sex, string title, double score, double wage);
//	void show();
//private:
//	double wage;
//};
//
//int main()
//{
//	Graduate g1("zhushuai", 23, 'm', "pro", 80, 90);
//	g1.show();
//
//	system("pause");
//	return 0;
//}
//
//Person::Person(string name, int age, char sex)
//{
//	this->name = name;
//	this->age = age;
//	this->sex =sex;
//}
//
//Teacher::Teacher(string name, int age, char sex, string title):Person(name, age, sex)
//{
//	this->title = title;
//}
//
//Student::Student(string name, int age, char sex, double score):Person(name, age, sex)
//{
//	this->score = score;
//}
//
//Graduate::Graduate(string name, int age, char sex, string title, double score, double wage):Teacher(name, age, sex, title),Student(name, age, sex, score),Person(name, age, sex)
//{
//	this->wage = wage;
//}
//
//void Graduate::show()
//{
//	cout << "name:" << name << endl;
//	cout << "age:" << age << endl;
//	cout << "sex:" << sex << endl;
//	cout << "title:" << title << endl;
//	cout << "score:" << score << endl;
//	cout << "wage:" << wage << endl;
//}