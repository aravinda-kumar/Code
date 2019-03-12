#include<iostream>
#include<set>
#include<algorithm>
#include<functional>
#include<string>
using namespace std;

int main()
{

	set<string> st;
	st.insert(string("abc"));
	st.insert(string("bcd"));
	st.insert(string("cde"));
	st.insert(string("def"));

	set<string>::iterator ite;
	for (ite = st.begin(); ite != st.end(); ite++)
	{
		cout << *ite << endl;
	}

	system("pause");
	return 0;
}