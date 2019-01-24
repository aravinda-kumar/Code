//#include<iostream>
//#include<string>
//using namespace std;
//
//class Person
//{
//    friend istream& read(istream& is, Person &per);
//    friend ostream& print(ostream& os, const Person &per);
//public:
//    Person(string name="NoName", string addr="None");
//    // 利用输入流中的数据来初始化
//    Person(istream &is);
//    // 拷贝构造函数
//    Person(const Person &per);
//    // 函数中数据的内容不可以发生改变，而且可以提高兼容性
//    // 所以使用常成员函数
//    string name_re() const;
//    string addr_re() const;
//    ~Person();
//private:
//    string name;
//    string addr;
//};
//
//istream& read(istream& is, Person &per);
//ostream& print(ostream& os, const Person &per);
//
//int main()
//{
//    const Person per1("zhushuai", "yancheng");
//    Person per2("johnson", "China");
//    cout << per1.name_re() << endl;
//    cout << per2.addr_re() << endl;
//    cout << "********************" << endl;
//
//    Person per3(cin);
//    print(cout, per3) << endl;
//    cout << "********************" << endl;
//
//    Person per4(per3);
//    print(cout, per4) << endl;
//
//    return 0;
//}
//
//Person::Person(string name, string addr)
//{
//    this->name = name;
//    this->addr = addr;
//}
//
//Person::Person(istream &is)
//{
//    read(is, *this);
//}
//
//Person::Person(const Person &per)
//{
//    this->name = per.name;
//    this->addr = per.addr;
//}
//
//Person::~Person()
//{
//    cout << name << " is deconstructing" << endl;
//}
//
//string Person::name_re() const
//{
//    return name;
//}
//
//string Person::addr_re() const
//{
//    return addr;
//}
//
//istream& read(istream& is, Person &per)
//{
//    is >> per.name >> per.addr;
//    return is;
//}
//
//ostream& print(ostream& os, const Person &per)
//{
//    os << per.name <<' ' << per.addr;
//    return os;
//}
