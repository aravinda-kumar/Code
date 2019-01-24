#include<iostream>
#include<string>
using namespace std;


typedef double num;
int b = 6;
class A
{
public:
	// typedef int num;
	void show()
	{cout << b << endl;}
	num a= 3.14;
};


int main()
{
    num a = 3.14;
    cout << a << endl;
    
    A b;
    b.show();
//    typedef int num;
//    num b = 3.14;
//    cout << b << endl;
//    
    return 0;
}
