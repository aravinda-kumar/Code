//#include <iostream>
//using namespace std;
//
//struct Student
//{
//	int num;
//	double score;
//};
//
//void print1(Student stu);
//void print2(Student *stu);
//void print3(Student &stu);
//
//int main()
//{
//	Student stu[3]={{1001,80},{1002,90},{1003,100}};
//	Student stu1={1000,70};
//
//	print1(stu1);
//	cout << endl;
//	print2(stu);
//	cout << endl;
//	print3(stu1);
//
//	system("pause");
//	return 0;
//}
//
//void print1(Student stu)
//{
//	cout << stu.num << ' ' << stu.score << endl;
//}
//
//void print2(Student *stu)
//{
//	int i_countx;
//	for(i_countx=0;i_countx<3;i_countx++)
//		cout << (stu+i_countx)->num << ' ' << (stu+i_countx)->score << endl;
//}
//
//void print3(Student &stu)
//{
//	cout << stu.num << ' ' << stu.score << endl;
//}