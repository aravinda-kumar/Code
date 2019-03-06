//#include <iostream>
//#include <string>
//using namespace std;
//
//class Teacher
//{
//public:
//	Teacher(string name, int age, string title);
//protected:
//	string name;
//	int age;
//	string title;
//};
//
//class Student
//{
//public:
//	Student(string name, char sex, double score);
//protected:
//	string name;
//	char sex;
//	double score;
//};
//
//class Graduate:public Teacher, public Student
//{
//public: 
//	Graduate(string name, char sex, int age, string title, double score, double wage);
//	void show_all();
//private:
//	double wage;
//};
//
//int main()
//{
//	Graduate g1("zhushuai",'m', 24, "pro", 90, 100);
//	g1.show_all();
//
//	system("pause");
//	return 0;
//}
//
//Teacher::Teacher(string name, int age, string title)
//{
//	this->name = name;
//	this->age = age;
//	this->title = title;
//}
//
//Student::Student(string name1, char sex, double score)
//{
//	this->name = name;
//	this->sex = sex;
//	this->score =score;
//}
//
//Graduate::Graduate(string name, char sex, int age, string title, double score, double wage):Teacher(name, age, title), Student(name, sex, score)
//{
//	this->wage = wage;
//}
//
//void Graduate::show_all()
//{
//	cout << "name:" << Student::name << endl;
//	cout << "sex:" << sex << endl;
//	cout << "age:" << age << endl;
//	cout << "title:" << title << endl;
//	cout << "score:" << score << endl;
//	cout << "wage:" << wage << endl;
//}