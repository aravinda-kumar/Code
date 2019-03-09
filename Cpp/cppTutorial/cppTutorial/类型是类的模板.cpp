#include<iostream>
using namespace std;

template <typename T>
class CAA
{
public:
	int a;
};

template <typename T1, typename T2>
class CFather
{
public:
	CFather(CAA<T1> &a)
	{

	}
	void fun()
	{
		cout << "CFather" << endl;
	}
};



int main()
{
	CAA<char> a;
	CFather<char, CAA<int>> pf(a);

	system("pause");
	return 0;
}