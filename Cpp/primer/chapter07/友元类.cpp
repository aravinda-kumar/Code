//#include<iostream>
//#include<string>
//using namespace std;
//
//// 对类进行声明使得Student类在编译的时候能够识别出
//// Teacher是一个类
//class Student;
//
//class Teacher
//{
//public:
//    Teacher()=default;
//    Teacher(string name, int age, string pos);
//    Teacher& show(Student &stu);
//private:
//    string name = "NoName";
//    int age = 0;
//    string pos = "None";
//};
//
//class Student
//{
//    // friend Teacher;
//    friend Teacher& Teacher::show(Student &stu);
//public:
//    Student()=default;
//    Student(string name, int age, double score);
//private:
//    string name = "NoName";
//    int age = 0;
//    double score = 0;
//};
//
//
//
//int main()
//{
//    Student stu("zhushuai", 21, 100);
//    Teacher tea("johnson", 32, "pro");
//    tea.show(stu);
//    return 0;
//}
//
//Student::Student(string name, int age, double score)
//{
//    this->name = name;
//    this->age = age;
//    this->score = score;
//}
//
//Teacher::Teacher(string name, int age, string pos)
//{
//    this->name = name;
//    this->age = age;
//    this->pos = pos;
//}
//
//Teacher& Teacher::show(Student &stu)
//{
//    cout << "My info:" << endl;
//    cout << "Name:" << name << endl;
//    cout << "age:" << age << endl;
//    cout << "pos:" << pos << endl;
//    cout << "My student's info:" << endl;
//    cout << "Name:" << stu.name << endl;
//    cout << "Age:" << stu.age << endl;
//    cout << "Score:" << stu.score << endl;
//    return *this;
//}
