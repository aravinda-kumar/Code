//#include<iostream>
//using namespace std;
//
//unsigned __int64 fac(const unsigned int a);
//int abs_i(const int &a);
//
//int main()
//{
//    unsigned int a = 0;
//    int b = 0;
//    cout << "请输入一个正整数:";
//    cin >> a;
//    unsigned int un_result = fac(a);
//    cout << a << "!=" << un_result << endl;
//
//    cout << "请输入一个整数:";
//    cin >> b;
//    int result = abs_i(b);
//    cout << b << "的绝对值是" << result << endl;
//
//    return 0;
//}
//
//unsigned __int64 fac(const unsigned int a)
//{
//    unsigned __int64 result = 0;
//    if (a == 1)
//        result = 1;
//    else
//        result = fac(a-1) * a;
//    return result;
//}
//
//int abs_i(const int &a)
//{
//    return a>0?a:-a;
//}
