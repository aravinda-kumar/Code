#include<iostream>
using namespace std;

class CStu
{
public:
	static int a;
	static const int b = 12;
	CStu()
	{
		a = 15;
	}
	static void fun()
	{
		cout << "this is static" << endl;
	}
};

int CStu::a = 12;

int main()
{
	cout << CStu::a << endl;
	CStu stu;
	cout << stu.a << endl;
	CStu::fun();
	system("pause");
	return 0;
}