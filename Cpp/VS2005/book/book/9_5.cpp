//#include <iostream>
//using namespace std;
//
//class Student
//{
//	friend void print_odd(Student *pt, int n);
//	friend void max(Student *pt, int n);
//public:
//	Student(int num, int score);
//private:
//	int num;
//	int score;
//};
//
//int main()
//{
//	Student stu[5]={Student(1001,70),Student(1002,80),Student(1003,90),Student(1004,100),Student(1005,70)};
//	print_odd(stu, 5);
//	
//	cout << "*******************************************" << endl;
//
//	max(stu, 5);
//
//	system("pause");
//	return 0;
//}
//
//Student::Student(int num, int score)
//{
//	this->num = num;
//	this->score = score;
//}
//
//void print_odd(Student *pt, int n)
//{
//	int i_countx;
//	for(i_countx=0;i_countx<n;i_countx+=2)
//		cout << (pt+i_countx)->num << ' ' << (pt+i_countx)->score << endl;
//}
//
//void max(Student *pt, int n)
//{
//	int i_countx=0;
//	int tmp=0;
//	for(i_countx=1;i_countx<n;i_countx++)
//		if((pt+tmp)->score < (pt+i_countx)->score)
//			tmp = i_countx;
//	cout << (pt+tmp)->num << ' ' << (pt+tmp)->score << endl;
//}