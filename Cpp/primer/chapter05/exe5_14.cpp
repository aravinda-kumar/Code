//#include<iostream>
//#include<vector>
//#include<string>
//#include<iterator>
//using namespace std;
//
//int main()
//{
//    vector<string> str_v;
//    string str;
//    int cnt = 1;
//    // 数据存储
//    vector<string> str_vtmp;
//    vector<int> cnt_v;
//
//    while(cin >> str)
//        str_v.push_back(str);
//
//    vector<string>::iterator start = str_v.begin();
//    vector<string>::iterator stop = str_v.end();
//
//    cout << "初始字符串为：" << endl;
//    while(start != stop)
//        cout << *start++ << " ";
//    cout << endl;
//
//    // start重新回到开始位置;
//    start = str_v.begin();
//
//    while(start != stop)
//    {
//        while(*start == *(start+1) && start+1 != stop)
//        {
//            ++cnt;
//            ++start;
//        }
//        str_vtmp.push_back(*start);
//        cnt_v.push_back(cnt);
//        cnt = 1;
//        ++start;
//    }
//
//    vector<string>::iterator tmp_start = str_vtmp.begin();
//    vector<string>::iterator tmp_stop = str_vtmp.end();
//    vector<int>::iterator cnt_start = cnt_v.begin();
//    vector<int>::iterator cnt_stop = cnt_v.end();
//
//    while(tmp_start != tmp_stop)
//    {
//        cout << *tmp_start++ << ":" << *cnt_start++ << endl;
//    }
//
//    cout << "出现次数最多的单词和次数分别是：" << endl;
//    cnt_start = cnt_v.begin();
//    int ctmp = 0;
//    int tmp = *cnt_start;
//    for(int i=0; cnt_start!=cnt_stop; ++cnt_start,++i)
//    {
//        if(tmp < *cnt_start)
//        {
//            tmp = *cnt_start;
//            ctmp = i;
//        }
//    }
//    cout << str_vtmp[ctmp] << ":" << cnt_v[ctmp] << endl;
//
//    return 0;
//}
