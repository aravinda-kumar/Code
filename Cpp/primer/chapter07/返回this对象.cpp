//#include<iostream>
//#include<string>
//using namespace std;
//
//class Student
//{
//public:
//    Student(string name="NoName", int age=0);
//    // this�����е�������Ҫ�����ı䣬���Բ��������ɳ���Ա����
//    void add_age(const Student &stu1);
//    void show() const;
//private:
//    string name;
//    int age;
//};
//
//int main()
//{
//    Student stu1("zhushuai", 20);
//    const Student stu2("Johnson", 21);
//
//    stu1.show();
//    stu2.show();
//    cout << "***************************" << endl;
//
//    stu1.add_age(stu2);
//    stu1.show();
//
//
//    return 0;
//}
//
//Student::Student(string name, int age)
//{
//    this->name = name;
//    this->age = age;
//}
//
//void Student::add_age(const Student &stu1)
//{
//    age += stu1.age;
//    // return *this;
//}
//
//void Student::show() const
//{
//    cout << "Name:" << name << endl;
//    cout << "Age:" << age << endl;
//}
