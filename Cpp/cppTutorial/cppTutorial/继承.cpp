#include<iostream>
using namespace std;

class CFather
{
public:
	static int z;
	int a;
	CFather()
	{
		a = 15;
	}
	void Show(int a)
	{
		cout << "CFather" << endl;
	}
};

int CFather::z = 12;

class CSon:public CFather
{
public:
	int a;
	CSon()
	{
		a = 13;
	}
	void Show()
	{
		cout << "CSon" << endl;
	}
};

int main()
{
	CSon s;
	cout << s.CFather::a << endl;
	s.CFather::Show(1);
	s.z = 14;
	cout << CSon::z << endl;
	
	system("pause");
	return 0;
}