//#include "iostream"
//#include <string>
//using namespace std;
//
//string name[50];
//string num[50];
//int n;
//
//void add()
//{
//	cout << "Please input the number of students:" ;
//	cin >> n;
//	int i;
//	for(i=0;i<n;i++)
//	{
//		cout << "Please input the information of NO."<< i+1 <<"  student:";
//		cin >> name[i] >> num [i];
//	}
//}
//
//void find(string str)
//{
//	cout << "************************************************************" << endl;;
//	int i;
//	for (i=0;i<n;i++)
//	{
//		if(name[i] == str)
//		{
//			cout << "NO." << i+1 << "  student is the one you wanna find." << endl;
//			cout << "The score is: " << num[i] << endl; 
//			break;
//		}
//	}
//	if(i==n)
//	{
//		cout << "No such person!" << endl;
//	}
//}
//int main()
//{
//	string str;
//	add();
//	int i;
//	for(i=0;i<n;i++)
//	{
//		cout << name[i] << "  " << num[i] << endl;
//	}
//	cout << "Please input the name of the student you wanna find:";
//	cin >> str;
//	find (str);
//	string str;
//	cin >> str;
//	cout << str << endl;
//	string str1;
//	cin >> str1;
//	cout << str1 << endl;
//	string str3;
//	str3=str1 + str;
//	cout << str3 << endl;
//	string string1;
//	string1="bingo";
//	cout << string1 << endl;
//	string str2;
//	str2="JZS";
//	str2[1]='z';
//	cout << str2 << endl;
//
//	cout << "hello world!" << endl;
//	string str1,str2,str3;
//	cout << "Please input 3 strings:" << endl;
//	cin >> str1 >> str2 >> str3;
//	string temp;
//	if(str1 > str2)
//	{
//		temp = str1; str1 = str2 ; str2 = temp;
//	}
//	if(str1 > str3)
//	{
//		temp = str1; str1 = str3 ; str3 = temp;
//	}
//	if(str2 > str3)
//	{
//		temp = str2; str2 = str3 ; str3 = temp;
//	}
//	cout << "The result is:" << endl;
//	cout << str1 << "  " << str2 << "  " << str3 << endl;
//	system("pause");
//	return 0;
//}