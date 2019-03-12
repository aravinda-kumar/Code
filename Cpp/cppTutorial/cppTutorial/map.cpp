//#include<iostream>
//#include<string>
//#include<map>
//#include<algorithm>
//#include<functional>
//using namespace std;
//
//void fun(pair<int, char> p)
//{
//	cout << p.first << ' ' << p.second << endl;
//}
//
//void MapConstruct()
//{
//	map<int, char> mp;
//
//	typedef pair<int, char> in_pair;
//
//	pair<map<int, char>::iterator, bool> result;
//	mp.insert(in_pair(1, 'a'));
//	result = mp.insert(in_pair(3, 'b'));
//	mp.insert(in_pair(5, 'a'));
//	mp.insert(in_pair(7, 'a'));
//	mp.insert(in_pair(9, 'a'));
//
//	//for_each(mp.begin(), mp.end(), fun);
//	//cout << "======================" << endl;
//
//	map<int, char>::iterator ite;
//	ite = mp.begin();
//	ite++;
//	ite++;
//	ite++;
//
//	mp.insert(ite, in_pair(2, 'z'));
//
//	//for_each(mp.begin(), mp.end(), fun);
//	//cout << "======================" << endl;
//
//	ite = mp.begin();
//	map<int, char> mp1;
//
//	mp1.insert(in_pair(4, 't'));
//	mp1.insert(ite, mp.end());
//
//	for_each(mp1.begin(), --mp1.end(), fun);
//	cout << "======================" << endl;
//
//	map<int, char> mp2(mp1);
//	for_each(mp2.begin(), --mp2.end(), fun);
//	cout << "======================" << endl;
//
//	map<int, char> mp3(++mp2.begin(), --mp2.end());
//	for_each(mp3.begin(), --mp3.end(), fun);
//	cout << "======================" << endl;
//
//}
//
//void MapProperty()
//{
//	map<int, char> mp;
//	typedef pair<int, char> in_pair;
//	cout << mp.size() << endl;
//	mp.insert(in_pair(1, 'a'));
//	cout << mp.size() << endl;
//	mp.insert(in_pair(2, 'b'));
//	cout << mp.size() << endl;
//	if (mp.count(1))
//	{
//		cout << "´æÔÚ" << endl;
//	}
//	map<int, char>::iterator ite;
//	for (ite = mp.begin(); ite != mp.end(); ite++)
//	{
//		cout << ite->first << ' ' << ite->second << endl;
//	}
//}
//
//void Mapdelete()
//{
//	typedef pair<int, char> in_pair;
//	map<int, char> mp;
//	mp.insert(in_pair(1, 'a'));
//	mp.insert(in_pair(2, 'b'));
//	mp.insert(in_pair(3, 'c'));
//	mp.insert(in_pair(4, 'd'));
//	mp.insert(in_pair(5, 'e'));
//	mp.insert(in_pair(6, 'f'));
//	mp.insert(in_pair(7, 'g'));
//	mp.insert(in_pair(8, 'h'));
//	mp.insert(in_pair(9, 'i'));
//	mp.insert(in_pair(10, 'j'));
//
//	map<int, char>::iterator ite;
//	
//	for_each(mp.begin(), mp.end(), fun);
//	cout << "======================================" << endl;
//
//	mp.erase(++mp.begin());
//	for_each(mp.begin(), mp.end(), fun);
//	cout << "======================================" << endl;
//
//	mp.erase(++mp.begin(), --mp.end());
//	for_each(mp.begin(), mp.end(), fun);
//	cout << "======================================" << endl;
//
//}
//
//void Mapfind()
//{
//	map<int, char> mp;
//	mp.insert(pair<int, char>(1, 'a'));
//	mp.insert(pair<int, char>(2, 'b'));
//	mp.insert(pair<int, char>(3, 'c'));
//	mp.insert(pair<int, char>(4, 'd'));
//	mp.insert(pair<int, char>(5, 'e'));
//	mp.insert(pair<int, char>(6, 'f'));
//	mp.insert(pair<int, char>(7, 'g'));
//	mp.insert(pair<int, char>(8, 'h'));
//	mp.insert(pair<int, char>(9, 'i'));
//	mp.insert(pair<int, char>(10, 'j'));
//
//	for_each(mp.begin(), mp.end(), fun);
//	cout << "======================================" << endl;
//
//	map<int, char>::iterator ite;
//	ite = mp.find(7);
//	cout << ite->first << ' ' << ite->second << endl;
//
//}
//
//void MapReverse()
//{
//	map<int, char, greater<int>> mp;
//	mp.insert(pair<int, char>(1, 'a'));
//	mp.insert(pair<int, char>(2, 'b'));
//	mp.insert(pair<int, char>(3, 'c'));
//	mp.insert(pair<int, char>(5, 'e'));
//	mp.insert(pair<int, char>(6, 'f'));
//	mp.insert(pair<int, char>(7, 'g'));
//	mp.insert(pair<int, char>(8, 'h'));
//	mp.insert(pair<int, char>(9, 'i'));
//	mp.insert(pair<int, char>(10, 'j'));
//
//	for_each(mp.begin(), mp.end(), fun);
//	cout << "======================================" << endl;
//
//	cout << mp.lower_bound(4)->first << endl;
//	cout << mp.upper_bound(4)->first << endl;
//	cout << "======================================" << endl;
//
//	cout << mp.equal_range(5).first->first << endl;
//	cout << mp.equal_range(5).second->first << endl;
//}
//
//void MultiMap()
//{
//	multimap<int, char> mmp;
//	mmp.insert(pair<int, char>(1, 'a'));
//	mmp.insert(pair<int, char>(1, 'b'));
//	mmp.insert(pair<int, char>(2, 'c'));
//	mmp.insert(pair<int, char>(3, 'd'));
//	mmp.insert(pair<int, char>(4, 'e'));
//	mmp.insert(pair<int, char>(5, 'f'));
//	mmp.insert(pair<int, char>(5, 'p'));
//
//	for_each(mmp.begin(), mmp.end(), fun);
//	cout << "=============================" << endl;
//
//	cout << mmp.count(5) << endl;
//	cout << "=============================" << endl;
//
//	cout << mmp.find(1)->first << ' ' << mmp.find(1)->second << endl;
//}
//
//int main()
//{
//	//MapConstruct();
//	//MapProperty();
//	//Mapdelete();
//	//Mapfind();
//	//MapReverse();
//	MultiMap();
//
//
//	system("pause");
//	return 0;
//}