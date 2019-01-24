//#include<iostream>
//#include<stdexcept>
//using namespace std;
//
//void div_2(double &a, double &b);
//
//int main()
//{
//    double a = 0;
//    double b = 0;
//    cout << "输入两个数：" << endl;
//    while(cin >> a >> b)
//    {
//        try
//        {
//            div_2(a, b);
//        }
//        catch (runtime_error err)
//        {
//            cout << err.what();
//            cout << "\n是否继续？";
//            char ch = 0;
//            if(ch=='n')
//                break;
//        }
//    }
//
//    return 0;
//}
//
//void div_2(double &a, double &b)
//{
//    double result=0;
//    if(b == 0) throw runtime_error ("被除数不能为0");
//    else
//    {
//        result = a / b;
//        cout << "商是:" << result << endl;
//    }
//}
