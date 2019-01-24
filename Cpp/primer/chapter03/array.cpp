//#include<iostream>
//#include<vector>
//#include<cstring>
//using namespace std;
//
//int main()
//{
//    int a[2][3] = {1,2,3,4,5,6};
//    int i=0,j=0;
//
//    // the first way:
//    for(i=0; i<2; i++)
//    {
//        for(j=0; j<3; j++)
//            cout << *(*(a+i)+j) << ' ';
//        cout << endl;
//    }
//
//    // the second way:
//    using int_array = int[3];
//    //typedef int int_array[3];
//    for(int_array *p=a; p<a+2; p++)
//    {
//        for(int *q=*p; q<*p+3; q++)
//            cout << *q << ' ';
//        cout << endl;
//    }
//
//    // the third way:
//    for(auto p=begin(a); p!=end(a); p++)
//    {
//        for(auto q=begin(*p); q!=end(*p); q++)
//            cout << *q << ' ';
//        cout << endl;
//    }
//    return 0;
//}
