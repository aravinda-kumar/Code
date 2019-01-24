#include<iostream>
#include<time.h>
using namespace std;

int* Array_size(int num);

int main()
{
    auto p = Array_size(4);
    for(int i=0; i<4;i++)
        cout << *(p+i) << endl;

    return 0;
}

int* Array_size(int num)
{
    int* p = new int[num];
    for (int i=0;i<num;i++)
        *(p+i)=i;
    return p;
}
