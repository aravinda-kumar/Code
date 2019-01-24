//#include<iostream>
//#include<vector>
//#include<iterator>
//using namespace std;
//
//int main()
//{
//    vector<int> v_int_1 = {0,1,1,2};
//    vector<int> v_int_2 = {0,1,1,2,3,5,8};
//    vector<int> v_int_tmp_1 = v_int_1.size()<v_int_2.size()? v_int_1: v_int_2;
//    vector<int> v_int_tmp_2 = v_int_1.size()>v_int_2.size()? v_int_1: v_int_2;
//    auto start_1 = v_int_tmp_1.begin();
//    auto stop_1 = v_int_tmp_1.end();
//    auto start_2 = v_int_tmp_2.begin();
//    for(; *start_1==*start_2; start_1++,start_2++);
//    if(start_1 == stop_1)
//        cout << "其中一个vector是另一个vector的前缀" << endl;
//    else
//        cout << "其中一个vector不是另一个vector的前缀" << endl;
//
//    return 0;
//}
