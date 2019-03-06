//#include <iostream>
//#include <fstream>
//using namespace std;
//
//struct Student
//{
//	char name[20];
//	int num;
//	int age;
//	char sex;
//};
//
//int main()
//{
//	Student stu[3];
//	ifstream infile;
//	infile.open("stu.txt", ios::binary|ios::in);
//	if(infile == 0)
//	{
//		cerr << "open error!" << endl;
//		abort();
//	}
//	
//	for(int i=0;i<3;i++)
//		infile.read((char *)&stu[i], sizeof(stu[i]));
//	infile.close();
//
//	for (int i=0;i<3;i++)
//	{
//		cout << "NO." << i+1 << endl;
//		cout << "Name:" << stu[i].name << endl;
//		cout << "Num:" << stu[i].num << endl;
//		cout << "Age:" << stu[i].age << endl;
//		cout << "Sex:" << stu[i].sex << endl << endl;
//	}
//
//	system("pause");
//	return 0;
//}