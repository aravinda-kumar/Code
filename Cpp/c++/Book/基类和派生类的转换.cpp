//#include <iostream>
//#include <string>
//using namespace std;
//
//class Student
//{
//public:
//	Student(int num, string name, float score);
//	void display();
//private:
//	int num;
//	string name;
//	float score;
//};
//
//class Graduate:public Student
//{
//public:
//	Graduate(int num, string name, float score, float wage);
//	void display();
//private:
//	float wage;
//};
//
//int main()
//{
//	Student stu(1001, "zhushuai", 80);
//	Graduate gra(1002, "johnson", 90, 100);
//	gra.display();
//	Student *pt=&stu;
//	pt->display();
//	
//	cout << "*********************" << endl;
//
//	pt=&gra;
//	pt->display();
//
//	cout << "*********************" << endl;
//
//	Student &stu1=stu;
//	stu1.display();
//	stu1 = gra;
//	stu1.display();
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
//	cout << "name:" << name << endl;
//	cout << "num:" << num << endl;
//	cout << "score:" << score << endl;
//}
//
//Graduate::Graduate(int num, string name, float score, float wage):Student(num, name, score)
//{
//	this->wage = wage;
//}
//
//void Graduate::display()
//{
//	Student::display();
//	cout << "wage:" << wage << endl;
//}