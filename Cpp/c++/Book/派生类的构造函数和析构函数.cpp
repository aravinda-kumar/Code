//#include <iostream>
//#include <string>
//using namespace std;
//
//class Student
//{
//public:
//	Student(string name, char sex, int num);
//	~Student();
//protected:
//	string name;
//	char sex;
//	int num;
//};
//
//class Student1:public Student
//{
//public:
//	Student1(string name, char sex, int num, int age, string addr);
//	~Student1();
//	void show();
//private:
//	int age;
//	string addr;
//};
//
//int main()
//{
//	Student1 stu("zhushuai", 'm', 1001, 23, "yancheng");
//	stu.show();
//
//	system("pause");
//	return 0;
//}
//
//Student::Student(string name, char sex, int num)
//{
//	this->name = name;
//	this->sex = sex;
//	this->num = num;
//}
//
//Student::~Student()
//{
//	cout << "基类的析构函数" << endl;
//}
//
//Student1::Student1(string name, char sex, int num, int age, string addr):Student(name, sex, num)
//{
//	this->age = age;
//	this->addr = addr;
//}
//
//void Student1::show()
//{
//	cout << "name:" << name << endl;
//	cout << "sex:" << sex << endl;
//	cout << "num:" << num << endl;
//	cout << "age:" << age << endl;
//	cout << "addr:" << addr << endl;
//}
//
//Student1::~Student1()
//{
//	cout << "子类的析构函数" << endl;
//}