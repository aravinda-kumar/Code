//#include <iostream>
//#include <string>
//#include <algorithm>
//#include <functional>
//using namespace std;
//
////����
//void Property()
//{
//	string str(16, 'a');
//	str.resize(3);
//	cout << str.capacity() << endl;
//	cout << str << endl;
//}
//
////���
//void StrCout()
//{
//	string str("abcdefg");
//
//	//<<�������string��������
//	cout << str << endl;
//	//�����ַ���str���׵�ַ���൱�����char*ָ����ַ���
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
////�޸�
//void StrModifier()
//{
//	//�޸�ָ����Ԫ��
//	string str("abcdefg");
//	str[2] = 'z';
//	str.at(3) = 'w';
//	cout << str << endl;
//
//	//�м����Ԫ��
//
//	//β��ƴ��
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
//	//Ĭ������ʽ�Ǵ�С����
//	sort(str.begin(), str.end());
//	cout << str << endl;
//
//	//Ĭ�ϴӴ�С
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