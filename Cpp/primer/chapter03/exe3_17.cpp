//#include<iostream>
//#include<string>
//#include<vector>
//#include<cctype>
//using namespace std;
//
//int main()
//{
//    vector<string> str_v;
//    string str[3];
////    while(cin >> str)
////        str_v.push_back(str);
//    for(int i=0; i<3; i++)
//    {
//        cin >> str[i];
//        str_v.push_back(str[i]);
//    }
//
//    cout << "The string in vector is:" << endl;
//    for(auto &str_a: str_v)
//        cout << str_a << endl;
//
//    for(auto &str_chg: str_v)
//        for(auto &str_chg1: str_chg)
//            str_chg1 = toupper(str_chg1);
//    // cctype中的函数仅对字符有效，而str_chg是字符串，所以在一次更改之后还需要再次对str_chg使用范围for循环；
//
//    cout << "The upper string in vector is:" << endl;
//    decltype(str_v.size()) len = 0;
//    for(len=0; len<str_v.size(); len++)
//        cout << str_v[len] << endl;
//
//    return 0;
//}
