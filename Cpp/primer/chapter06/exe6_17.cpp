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
//        cout << "�����ַ���:" << endl;
//        cin >> str;
//        if(str == "q")
//            break;
//        if(inbigalpha(str))
//        {
//            cout << "�ַ����к��д�д��ĸ" << endl;
//            upper_to_lower(str);
//            cout << "ת��֮��Ľ����:" << endl << str << endl;
//        }
//        else
//            cout << "�ַ����в����д�д��ĸ" << endl;
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
