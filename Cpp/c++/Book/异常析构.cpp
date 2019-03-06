//#include <iostream>
//#include <string>
//using namespace std;
//
//class Student
//{
//public:
//	Student(int num, string name)
//	{
//		this->num = num;
//		this->name = name;
//		cout << "constructor-" << this->num << endl;
//	}
//	~Student()
//	{
//		cout << "destructor-" << this->num <<endl;
//	}
//	void get_data();
//private:
//	int num;
//	string name;
//};
//
//void fun();
//
//int main()
//{
//	cout << "main begin" << endl;
//	cout << "call fun()" << endl;
//	try
//	{
//		fun();
//	}
//	catch(int num)
//	{
//		cout << "num=" <<num << ", error!" << endl;
//	}
//	system("pause");
//	return 0;
//}
//
//void Student::get_data()
//{
//	if(this->num == 0) throw num;
//	else
//		cout << num << ' ' << name << endl;
//	cout << "in get_data()" << endl;
//}
//
//void fun()
//{
//	Student stud1(1001, "Tan");
//	stud1.get_data();
//
//	Student stud2(0, "Li");
//	stud2.get_data();
//}