//#include <iostream>
//#include <string>
//using namespace std;
//
//class Student
//{
//public:
//	void get_value();
//	void display();
//private:
//	int num;
//	string name;
//	char sex;
//};
//
//class Student1:public Student
//{
//public:
//	void get_value_1();
//	void display_1();
//private:
//	int age;
//	string addr;
//};
//
//int main()
//{
//	Student1 stu;
//	// public继承子类对象可以直接调用基类中公用成员函数;
//	stu.get_value();
//	stu.get_value_1();
//	stu.display();
//	stu.display_1();
//
//	system("pause");
//	return 0;
//}
//
//void Student::get_value()
//{
//	cin >> num >> name >> sex;
//}
//
//void Student::display()
//{
//	cout << "num:" << num << endl;
//	cout << "name:" << name << endl;
//	cout << "sex:" << sex << endl;
//}
//
//void Student1::get_value_1()
//{
//	cin >> age >> addr;
//}
//
//void Student1::display_1()
//{
//	cout << "age:" << age << endl;
//	cout << "addr:" << addr << endl;
//}