#include<iostream>
#include<string>
#include<map>
#include<algorithm>
using namespace std;

void fun(pair<int, char> p)
{
	cout << p.first << ' ' << p.second << endl;
}

void MapConstruct()
{
	map<int, char> mp;

	typedef pair<int, char> in_pair;

	pair<map<int, char>::iterator, bool> result;
	mp.insert(in_pair(1, 'a'));
	result = mp.insert(in_pair(3, 'b'));
	mp.insert(in_pair(5, 'a'));
	mp.insert(in_pair(7, 'a'));
	mp.insert(in_pair(9, 'a'));

	//for_each(mp.begin(), mp.end(), fun);
	//cout << "======================" << endl;

	map<int, char>::iterator ite;
	ite = mp.begin();
	ite++;
	ite++;
	ite++;

	mp.insert(ite, in_pair(2, 'z'));

	//for_each(mp.begin(), mp.end(), fun);
	//cout << "======================" << endl;

	ite = mp.begin();
	map<int, char> mp1;

	mp1.insert(in_pair(4, 't'));
	mp1.insert(ite, mp.end());

	for_each(mp1.begin(), --mp1.end(), fun);
	cout << "======================" << endl;

	map<int, char> mp2(mp1);
	for_each(mp2.begin(), --mp2.end(), fun);
	cout << "======================" << endl;

	map<int, char> mp3(++mp2.begin(), --mp2.end());
	for_each(mp3.begin(), --mp3.end(), fun);
	cout << "======================" << endl;

}

void MapProperty()
{
	map<int, char> mp;
	typedef pair<int, char> in_pair;
	cout << mp.size() << endl;
	mp.insert(in_pair(1, 'a'));
	cout << mp.size() << endl;
	mp.insert(in_pair(2, 'b'));
	cout << mp.size() << endl;
	if (mp.count(1))
	{
		cout << "´æÔÚ" << endl;
	}
	map<int, char>::iterator ite;
	for (ite = mp.begin(); ite != mp.end(); ite++)
	{
		cout << ite->first << ' ' << ite->second << endl;
	}
}

int main()
{
	//MapConstruct();
	MapProperty();


	system("pause");
	return 0;
}