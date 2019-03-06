//#include <iostream>
//#include <fstream>
//using namespace std;
//
//struct Student
//{
//	char name[20];
//	int num;
//	double score;
//};
//
//int main()
//{
//	Student stu[5]={"li", 1001, 18, "fang", 1002, 19, "wang", 1003, 17, "deng",1005,90, "zheng", 1006, 80};
//	fstream iofile;
//	// 文件信息存入磁盘
//	iofile.open("stu.txt", ios::in|ios::out|ios::binary);
//	if(iofile == 0)
//	{
//		cerr << "open error!" << endl;
//		abort();
//	}
//	
//	for(int i=0;i<5;i++)
//		iofile.write((char *)&stu[i], sizeof(stu[i]));
//	
//	// 读1,3,5位置的学生信息；
//	Student stu1[5];
//
//	for(int i=0;i<5;i=i+2)
//	{
//		iofile.seekg(i*sizeof(stu[1]), ios::beg);
//		iofile.read((char *)&stu1[i/2], sizeof(stu[1]));
//		cout << stu1[i/2].name << ' ' << stu1[i/2].num << ' ' << stu1[i/2].score << endl;
//	}
//	cout << endl;
//	
//	iofile.seekg(2*sizeof(stu[1]), ios::beg);
//	strcpy(stu[2].name, "zhushuai");
//	stu[2].num = 18217191;
//	stu[2].score = 356;
//	iofile.write((char *)&stu[2], sizeof(stu[2]));
//
//	iofile.seekg(0,ios::beg);
//	for(int i=0;i<5;i++)
//		iofile.read((char *)&stu[i], sizeof(stu[1]));
//
//	for (int i=0;i<5;i++)
//	{
//		cout << "NO." << i+1 << endl;
//		cout << "Name:" << stu[i].name << endl;
//		cout << "Num:" << stu[i].num << endl;
//		cout << "Score:" << stu[i].score << endl;
//	}
//	iofile.close();
//  
//	system("pause");
//	return 0;
//}