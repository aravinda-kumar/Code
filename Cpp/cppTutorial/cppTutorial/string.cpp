//#include <iostream>
//#include <string>
//#include <algorithm>
//#include <functional>
//using namespace std;
//
////属性
//void Property()
//{
//	string str(16, 'a');
//	str.resize(3);
//	cout << str.capacity() << endl;
//	cout << str << endl;
//}
//
////输出
//void StrCout()
//{
//	string str("abcdefg");
//
//	//<<运算符被string类重载了
//	cout << str << endl;
//	//返回字符串str的首地址，相当于输出char*指向的字符串
//	cout << str.c_str() << endl;
//
//	//cout << str[8] << endl;
//	try
//	{
//		cout << str.at(8) << endl;
//	}
//	catch (out_of_range &a)
//	{
//		cout << a.what() << endl;
//	}
//}
//
////修改
//void StrModifier()
//{
//	//修改指定的元素
//	string str("abcdefg");
//	str[2] = 'z';
//	str.at(3) = 'w';
//	cout << str << endl;
//
//	//中间插入元素
//
//	//尾巴拼接
//
//	char str1[6] = {0};
//	str.copy(str1, 2, 3);
//	cout << str1 << endl;
//}
//
//void FunIterator()
//{
//	string str("abc");
//	string str1("defg");
//	str.append(str1.begin() + 1, str1.end() - 1);
//	cout << str << endl;
//	//abcef
//
//	cout << "=========================" << endl;
//	str.erase(str.begin() + 2);
//	cout << str << endl;
//
//	str.insert(str.begin() + 2, 3, 'A');
//	cout << str << endl;
//	
//}
//
//void fun(char c)
//{
//	cout << c;
//}
//
//void FunForeach()
//{
//	string str("qwertyuiop");
//
//	for_each(str.begin(), str.end(), fun);
//	cout << endl;
//
//	cout << "=======================" << endl;
//
//	//默认排序方式是从小到大
//	sort(str.begin(), str.end());
//	cout << str << endl;
//
//	//默认从大到小
//	sort(str.begin(), str.end(), greater<char>());
//	cout << str << endl;
//}
//
//int main()
//{
//	FunForeach();
//
//	system("pause");
//	return 0;
//}