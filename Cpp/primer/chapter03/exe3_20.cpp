//#include<iostream>
//#include<string>
//#include<vector>
//using namespace std;
//
//int main()
//{
//    int num;
//    vector<int> v_int;
//    while(cin >> num)
//    {
//        v_int.push_back(num);
//    }
//
//    decltype(v_int.size()) len = 0;
//    for(len=0; len<v_int.size(); len++)
//        if(len % 2 == 1)
//        {
//            cout << v_int[len] + v_int[len-1] << endl;
//            if(len+1 == v_int.size()-1)
//                cout << v_int[len+1] << endl;
//        }
//
//    for(len=0; len<v_int.size()/2; len++)
//    {
//        cout << v_int[len] + v_int[v_int.size()-1-len] << endl;
//    }
//    if(v_int.size()%2==1)
//        cout << v_int[v_int.size()/2] << endl;
//
//
//    return 0;
//}
