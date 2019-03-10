#include"MyString.h"

int main()
{
	CMyString str("abcefg");

	CMyString str2(str);
	
	const char *p1 = str.c_str();
	const char *p2 = str2.c_str();

	cout << (int)p1 << "     " << p1 << endl;
	cout << (int)p2 << "     " << p2 << endl;

	cout << str << endl;
	cout << str2 << endl;

	cout << "====================" << endl;
	cin >> str2;
	cout << str2 << endl;


	system("pause");
	return 0;
}