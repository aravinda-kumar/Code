//#include<iostream>
//#include<string>
//#include<vector>
//#include<algorithm>
//#include<functional>
//#include<ctime>
//using namespace std;
//
//void STLDefine()
//{
//	vector<int> vec;
//}
//
//void STLConstructor()
//{
//	vector<int> vec1;
//	//cout << vec[0] << endl;
//	vector<char> vec2(5, 'a');
//	cout << vec2[0] << endl;
//
//	vector<char> vec3(vec2);
//	cout << vec2[3] << endl;
//
//	vector<char> vec4(vec3.begin(), vec3.end());
//	cout << vec4[4] << endl;
//
//	string str;
//	str = "zhushuai";
//	str.erase(str.begin() + 3, str.end());
//	cout << str << endl;
//}
//
////容量的大小
//void STLCapacity()
//{
//	vector<int> vec(12);
//	cout << vec.capacity() << endl;
//	vec.push_back(1);
//	cout << vec[12] << endl;
//	cout << vec.size() << endl;
//	vec.reserve(50);
//	vec.resize(51);
//	cout << vec.capacity() << endl;
//}
//
//void fun(int a)
//{
//	cout << a << "_";
//}
////输出
//void STLCout()
//{
//	vector<int> vec;
//	for (int i = 0; i < 10; i++)
//	{
//		vec.push_back(i);
//	}
//	vector<int>::iterator ite;
//	for (ite = vec.begin(); ite != vec.end(); ite++)
//	{
//		cout << *ite << " ";
//	}
//	cout << endl;
//	cout << vec.capacity() << endl;
//	cout << vec.back() << endl;
//
//	for_each(vec.begin(), vec.end(), fun);
//	cout << endl;
//	for(int a:vec)
//	{
//		cout << a << endl;
//	}
//}
//
////增加
//void STLInsert()
//{
//	vector<int> vec1(12, 0);
//	vector<int> vec2(10, 1);
//	vec1.swap(vec2);
//	//vec.insert(vec.begin() + 2, 2, 12);
//	for_each(vec1.begin(), vec1.end(), fun);
//	cout << endl;
//	//vec.pop_back();
//	for_each(vec2.begin(), vec2.end(), fun);
//	cout << endl;
//	//vec.erase(vec.begin() + 2, vec.end() - 5);
//	//for_each(vec.begin(), vec.end(), fun);
//	//cout << endl;
//}
//
////排序
//void STLSort()
//{
//	vector<int> vec;
//	for (int i = 0; i < 10; i++)
//	{
//		//没有申请空间，无法下标运算
//		//vec.at(i) = i + 1;
//		vec.push_back(i + 1);
//	}
//	sort(vec.begin(), vec.end(), greater<int>());
//	for (int item : vec)
//	{
//		cout << item << ' ';
//	}
//	cout << endl;
//
//	sort(vec.begin(), vec.end());
//	for (int item : vec)
//	{
//		cout << item << ' ';
//	}
//	cout << endl;
//
//	random_shuffle(vec.begin(), vec.end());
//	for (int item : vec)
//	{
//		cout << item << ' ';
//	}
//	cout << endl;
//	vec.clear();
//	cout << vec.size() << endl;
//	cout << vec.capacity() << endl;
//}
//
//int main()
//{
//	STLSort();
//
//	srand((unsigned int)time(NULL));
//	cout << rand() << endl;
//
//
//
//	system("pause");
//	return 0;
//}