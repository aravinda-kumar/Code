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
//    cout << "������������" << endl;
//    while(cin >> a >> b)
//    {
//        try
//        {
//            div_2(a, b);
//        }
//        catch (runtime_error err)
//        {
//            cout << err.what();
//            cout << "\n�Ƿ������";
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
//    if(b == 0) throw runtime_error ("����������Ϊ0");
//    else
//    {
//        result = a / b;
//        cout << "����:" << result << endl;
//    }
//}
