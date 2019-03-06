//#include<iostream>
//#include<string>
//using namespace std;
//
//void input_info(string s_stu[], int i_num[], int i_n);
//int find_info(string s_stu[], int i_num[], string s_name);
//
//int main()
//{
//	string s_stu[50];
//	int i_num[50];
//
//	int i_n, i_num_stu;
//	cout << "Please input student's number:";
//	cin >> i_n;
//	input_info(s_stu,i_num, i_n);
//	string s_name;
//	cout << "Please input the student's name you wanna find:" << endl;
//	cin >> s_name;
//	i_num_stu = find_info(s_stu, i_num, s_name);
//	if(i_num_stu ==0)
//		cout << "Student Doesn't exit!" << endl;
//	else
//		cout << "The student's number is:" << i_num_stu << endl;
//	system("pause");
//	return 0;
//}
//
//void input_info(string s_stu[], int i_num[], int i_n)
//{
//	int i_tmp;
//	for(i_tmp=0;i_tmp<i_n;i_tmp++)
//	{
//		cout << "Input name and number of student " << i_tmp+1 << ":";
//		cin >> s_stu[i_tmp] >> i_num[i_tmp];
//	}
//	s_stu[i_tmp]="0";
//	i_num[i_tmp]=0;
//}
//
//int find_info(string s_stu[], int i_num[], string s_name)
//{
//	int i_tmp;
//	for(i_tmp=0;;i_tmp++)
//	{
//		if(s_stu[i_tmp]==s_name || (s_stu[i_tmp]=="0" && i_num[i_tmp]==0))
//			break;
//	}
//	return i_num[i_tmp];
//}