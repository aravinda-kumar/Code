//#include<iostream>
//#include<iterator>
//#include<string>
//#include<cctype>
//#include<vector>
//using namespace std;
//
//class Student
//{
//public:
//    Student();
//    Student(string name, int age);
//    void show();
//private:
//    string name;
//public:
//    int age;
//};
//
//int main()
//{
////    string s("some string");
////    auto start = s.begin();
////    auto start1 = s.begin();
////    auto stop = s.end();
////    start1 += 3;
////    if(start < stop && start1 < stop)
////    {
////        if(start < stop)
////            cout << "<" << endl;
////        else
////            cout << ">=" << endl;
////    }
//    vector<int> v_int;
//    for(int i=0; i<10; i++)
//        v_int.push_back(i+1);
//
//    auto start = v_int.cbegin();
//    auto stop = v_int.cend();
//    auto mid = start + (stop - start)/2;
//    int sought;
//    cout << "INPUT THE NUMBER YOU WANT TO SEEK:";
//    cin >> sought;
//    while(mid != stop && *mid != sought && mid != start)
//    {
//        if(sought < *mid)
//            stop = mid;
//        if(sought > *mid)
//            start = mid + 1;
//        mid = start + (stop - start)/2;
//    }
//    if(mid == stop || mid == start)
//        cout << "does not exit" << endl;
//    else
//        cout << mid - start + 1 << endl;
//
//    return 0;
//}
//
//Student::Student()
//{
//    this->name = "defautl";
//    this->age = 0;
//}
//
//Student::Student(string name, int age)
//{
//    this->name = name;
//    this->age = age;
//}
//
//void Student::show()
//{
//    cout << name << endl;
//    cout << age << endl;
//}
