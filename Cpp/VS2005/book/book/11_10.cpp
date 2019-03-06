//#include <iostream>
//#include <string>
//using namespace std;
//
//class Teacher
//{
//public:
//	Teacher(string name, int age, char sex, string title);
//protected:
//	string name;
//	int age;
//	char sex;
//	string title;
//};
//
//class Cadre
//{
//public:
//	Cadre(string name, int age, char sex, string post);
//protected:
//	string name;
//	int age;
//	char sex;
//	string post;
//};
//
//class Teacher_Cadre;
//class Professor
//{
//	friend Teacher_Cadre;
//public:
//	Professor(__int64 tel, string addr);
//protected:
//	void show();
//	__int64 tel;
//	string addr;
//};
//
//class Teacher_Cadre:public Teacher, public Cadre
//{
//public:
//	Teacher_Cadre(string name, int age, char sex, string title, string post, __int64 tel, string addr, double wages);
//	void display();
//protected:
//	Professor pro;
//	double wages;
//};
//
//int main()
//{
//	Teacher_Cadre t1("zhushuai", 23, 'm', "student", "pro", 15151855260, "yancheng", 100);
//	t1.display();
//
//	system("pause");
//	return 0;
//}
//
//Teacher::Teacher(string name, int age, char sex, string title)
//{
//	this->name = name;
//	this->age = age;
//	this->sex = sex;
//	this->title = title;
//}
//
//Cadre::Cadre(string name, int age, char sex, string post)
//{
//	this->name = name;
//	this->age = age;
//	this->sex = sex;
//	this->post = post;
//}
//
//Professor::Professor(__int64 tel, string addr)
//{
//	this->tel = tel;
//	this->addr = addr;
//}
//
//Teacher_Cadre::Teacher_Cadre(string name, int age, char sex, string title, string post, __int64 tel, string addr, double wages):
//Teacher(name, age, sex, title), Cadre(name, age, sex, post),pro(tel, addr)
//{
//	this->wages = wages;
//}
//
//void Professor::show()
//{
//	cout << "addr:" << addr << endl;
//	cout << "tel:" << tel << endl;
//}
//
//void Teacher_Cadre::display()
//{
//	cout << "name:" << Teacher::name << endl;
//	cout << "age:" << Teacher::age << endl;
//	cout << "sex:" << Cadre::sex << endl;
//	cout << "title:" << title << endl;
//	cout << "post:" << post << endl;
//	cout << "addr:" << pro.addr << endl;
//	cout << "tel:" << pro.tel << endl;
//	cout << "wages:" << wages << endl;
//}