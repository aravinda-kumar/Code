#include <iostream>
#include <string>
using namespace std;

// Ù–‘
void Property()
{
	string str(16, 'a');
	str.resize(3);
	cout << str.capacity() << endl;
	cout << str << endl;
}

int main()
{
	Property();

	system("pause");
	return 0;
}