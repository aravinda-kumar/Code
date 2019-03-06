//#include <iostream>
//#include <string>
//using namespace std;
//
//class Student
//{
//public:
//	Student(int num, string name, float score);
//	// virtual	 float area()const=0;
//	void display();
//protected:
//	int num;
//	string name;
//	float score;
//};
//
//class Graduate:public Student
//{
//public:
//	Graduate(int num, string name, float score, float wage);
//	virtual void display();
//protected:
//	float wage;
//};
//
//class Teacher:public Graduate
//{
//public:
//	Teacher(int num, string name, float score, float wage ,string pos);
//	virtual void display();
//protected:
//	string pos;
//};
//
//int main()
//{
//	Student s1(1001, "zhushuai", 90);
//	Graduate g1(1002, "johnson", 90, 100);
//	Teacher t1(1003, "jethro", 101, 102, "pro");
//	Graduate *pt=&g1;
//	pt->display();
//	pt=&t1;
//	pt->display();
//
//	system("pause");
//	return 0;
//}
//
//Student::Student(int num, string name, float score)
//{
//	this->num = num;
//	this->name = name;
//	this->score = score;
//}
//
//void Student::display()
//{
//	cout << "\nnum:" << num << "\nname:" << name << "\nscore:" << score << endl;
//}
//
//Graduate::Graduate(int num, string name, float score, float wage):Student(num, name, score)
//{
//	this->wage = wage;
//}
//
//void Graduate::display()
//{
//	cout << "\nnum:" << num << "\nname:" << name << "\nscore:" << score << "\nwage:" << wage << endl;
//}
//
//Teacher::Teacher(int num, string name, float score, float wage ,string pos):Graduate(num, name, score, wage)
//{
//	this->pos = pos;
//}
//
//void Teacher::display()
//{
//	cout << "\nnum:" << num << "\nname:" << name << "\nscore:" << score << "\nwage:" << wage << "\npos:"<< pos << endl;
//}