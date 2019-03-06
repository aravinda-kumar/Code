//#include <iostream>
//#include <string>
//using namespace std;
//
//class Student
//{
//public:
//	Student(string name, char sex, int num);
//	~Student();
//	void display();
//protected:
//	string name;
//	char sex;
//	int num;
//};
//
//class Student1:public Student
//{
//public:
//	Student1(string name, char sex, int num, string name_m, char sex_m, int num_m, int age, string addr);
//	~Student1();
//	void show();
//	void show_monitor();
//private:
//	int age;
//	string addr;
//	Student monitor;
//};
//
//int main()
//{
//	Student1 stu("zhushuai", 'm', 1001, "johnson", 'm', 1002, 23, "yancheng");
//	stu.show();
//	stu.show_monitor();
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
//void Student::display()
//{
//	cout << name << endl;
//	cout << sex << endl;
//	cout << num << endl;
//}
//
//Student1::Student1(string name, char sex, int num, string name_m, char sex_m, int num_m, int age, string addr):Student(name, sex, num),monitor(name_m, sex_m, num_m)	
//
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
//
//void Student1::show_monitor()
//{
//	cout << "Monitor is:" <<  endl;
//	monitor.display();
//}