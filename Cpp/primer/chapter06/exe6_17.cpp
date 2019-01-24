//#include<iostream>
//#include<cctype>
//#include<string>
//#include<iterator>
//using namespace std;
//
//bool inbigalpha(const string &str);
//void upper_to_lower(string &str);
//
//int main()
//{
//    string str;
//    while(1)
//    {
//        cout << "输入字符串:" << endl;
//        cin >> str;
//        if(str == "q")
//            break;
//        if(inbigalpha(str))
//        {
//            cout << "字符串中含有大写字母" << endl;
//            upper_to_lower(str);
//            cout << "转换之后的结果是:" << endl << str << endl;
//        }
//        else
//            cout << "字符串中不含有大写字母" << endl;
//    }
//
//    return 0;
//}
//
//bool inbigalpha(const string &str)
//{
//    bool result = false;
//    string::const_iterator start = str.cbegin();
//    string::const_iterator stop = str.cend();
//    while (start != stop)
//    {
//        if(*start >= 'A' && *start <= 'Z')
//        {
//            result = true;
//            break;
//        }
//        ++start;
//    }
//    return result;
//}
//
//void upper_to_lower(string &str)
//{
////    string::iterator start = str.begin();
////    string::iterator stop = str.end();
////    while(start != stop)
////    {
////        cout << *start << endl;
////        *start = tolower(*start);
////        cout << *start << endl;
////        ++start;
////    }
//    for(auto &ch: str)
//        ch = tolower(ch);
//}
