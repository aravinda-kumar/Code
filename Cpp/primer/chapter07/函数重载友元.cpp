//#include<iostream>
//#include<string>
//using namespace std;
//
//class Student
//{
//    friend void show(Student &stu);
//    friend void show(Student &stu1, Student &stu2);
//public:
//    Student()=default;
//    Student(string name, int age, double score);
//private:
//    string name = "NoName";
//    int age = 0;
//    double score = 0;
//};
//
//void show(Student &stu);
//void show(Student &stu1, Student &stu2);
//
//int main()
//{
//    Student stu1("zhushuai", 21, 100);
//    Student stu2("johnson", 22, 90);
//    show(stu1);
//
//    cout << "*********************" << endl;
//
//    show(stu1, stu2);
//
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
//void show(Student &stu)
//{
//    cout << "Student's info:" << endl;
//    cout << "Name:" << stu.name << endl;
//    cout << "Age:" << stu.age << endl;
//    cout << "Score:" << stu.score << endl;
//}
//
//void show(Student &stu1, Student &stu2)
//{
//    cout << "Stu1.info:" << endl;
//    cout << "stu1.name:" << stu1.name << endl;
//    cout << "stu1.age:" << stu1.age << endl;
//    cout << "stu1.score:" << stu1.score << endl;
//
//    cout << "*******************************" << endl;
//
//    cout << "Stu2.info:" << endl;
//    cout << "stu2.name:" << stu2.name << endl;
//    cout << "stu2.age:" << stu2.age << endl;
//    cout << "stu2.score:" << stu2.score << endl;
//}
