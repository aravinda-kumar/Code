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
//class Student1:protected Student
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
//	// protected继承时
//	// 基类中公有成员和保护成员都变成子类的保护成员
//	// 基类中的私有成员在子类中不可见
//	// 所以对于子类的对象而言，其不可以调用子类的保护成员
//	// 但这些保护成员可以通过子类中的成员函数在类中调用
//	// private和protected继承在一级继承中实际效果相同
//	// 多级继承时会有不同的效果；
//	stu.get_value_1();
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
//	get_value();
//	cin >> age >> addr;
//}
//
//void Student1::display_1()
//{	
//	display();
//	cout << "age:" << age << endl;
//	cout << "addr:" << addr << endl;
//}