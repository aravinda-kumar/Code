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
//	Student stu[3]={"li", 1001, 18, 'f', "fang", 1002, 19, 'm', "wang", 1003, 17, 'f'};
//	ofstream stufile;
//	stufile.open("stu.txt", ios::binary);
//	if(stufile == 0)
//	{
//		cerr << "open error!" << endl;
//		abort();
//	}
//	
//	for(int i=0;i<3;i++)
//	{
//		stufile.write((char *)&stu[i], sizeof(stu[i]));
//	}
//	stufile.close();
//
//	system("pause");
//	return 0;
//}