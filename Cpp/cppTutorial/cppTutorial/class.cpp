#include<iostream>
using namespace std;

class CPeople
{
public:
	int a;
	void fun()
	{
		cout << "class CPeople" << endl;
	}
};

int main()
{
	CPeople people;
	people.fun();

	//CPeople *pt = new CPeople;
	CPeople *pt = &people;
	pt->a = 12;
	pt->fun();

	system("pause");
	return 0;
}