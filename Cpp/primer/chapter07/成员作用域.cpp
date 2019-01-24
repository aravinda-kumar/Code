//#include<iostream>
//#include<string>
//using namespace std;
//
//int height;
//class Screen
//{
//public:
//    typedef string::size_type pos;
//    void setHeight(pos);
//    pos height = 0;
//
//};
//
//Screen::pos verify(Screen::pos);
//
//void Screen::setHeight(pos var)
//{
//    height = verify(var);
//}
//
//int main()
//{
//
//    return 0;
//}
//
//Screen::pos verify(Screen::pos var)
//{
//    return var;
//}

//#include<iostream>
//#include<string>
//#include<ostream>
//using namespace std;
//
//class Student
//{
//public:
//    Student()=default;
//    Student(string name, int age);
//    Student &add_age_r();
//    Student add_age();
//    void add_age_v();
//    void show();
//private:
//    string name = "NoName";
//    int age = 0;
//};
//
//int main()
//{
//    Student stu("zhushuai", 23);
//    stu.add_age().add_age().show();
//    stu.show();
//    // stu.add_age_v().show();
//    stu.add_age_r();
//    stu.show();
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
//Student& Student::add_age_r()
//{
//    ++age;
//    return *this;
//}
//
//Student Student::add_age()
//{
//    ++age;
//    return *this;
//}
//
//void Student::add_age_v()
//{
//    ++age;
//}
//
//void Student::show()
//{
//    cout << "Name:" << name << endl;
//    cout << "Age:" << age << endl;
//}
