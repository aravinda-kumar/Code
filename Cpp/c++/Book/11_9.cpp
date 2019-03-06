//#include <iostream>
//#include <string>
//using namespace std;
//
//class Teacher
//{
//public:
//	Teacher(string name, int age, char sex, string addr, __int64 tel, string title);
//protected:
//	string name;
//	int age;
//	char sex;
//	string addr;
//	__int64 tel;
//	string title;
//};
//
//class Cadre
//{
//public:
//	Cadre(string name, int age, char sex, string addr, __int64 tel, string post);
//protected:
//	string name;
//	int age;
//	char sex;
//	string addr;
//	__int64 tel;
//	string post;
//};
//
//class Teacher_Cadre:public Teacher, public Cadre
//{
//public:
//	Teacher_Cadre(string name, int age, char sex, string addr, __int64 tel, string title, string post, double wages);
//	void display();
//protected:
//	double wages;
//};
//
//int main()
//{
//	Teacher_Cadre t1("zhushuai", 23, 'm', "yancheng", 15151855260, "student", "pro", 100);
//	t1.display();
//
//	system("pause");
//	return 0;
//}
//
//Teacher::Teacher(string name, int age, char sex, string addr, __int64 tel, string title)
//{
//	this->name = name;
//	this->age = age;
//	this->sex = sex;
//	this->addr = addr;
//	this->tel = tel;
//	this->title = title;
//}
//
//Cadre::Cadre(string name, int age, char sex, string addr, __int64 tel, string post)
//{
//	this->name = name;
//	this->age = age;
//	this->sex = sex;
//	this->addr = addr;
//	this->tel = tel;
//	this->post = post;
//}
//
//Teacher_Cadre::Teacher_Cadre(string name, int age, char sex, string addr, __int64 tel, string title, string post, double wages):
//Teacher(name, age, sex, addr, tel, title), Cadre(name, age, sex, addr, tel, post)
//{
//	this->wages = wages;
//}
//
//void Teacher_Cadre::display()
//{
//	cout << "name:" << Teacher::name << endl;
//	cout << "age:" << Teacher::age << endl;
//	cout << "sex:" << Teacher::sex << endl;
//	cout << "addr:" << Cadre::addr << endl;
//	cout << "tel:" << Cadre::tel << endl;
//	cout << "title:" << title << endl;
//	cout << "post:" << post << endl;
//	cout << "wages:" << wages << endl;
//}