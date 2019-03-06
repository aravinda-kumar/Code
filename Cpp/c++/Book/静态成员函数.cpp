//#include <iostream>
//using namespace std;
//
//class Student
//{
//public:
//	Student(int n, int a, float s):num(n),age(a),score(s){}
//	void total();
//	static float average();
//	static float sum;
//	static float count;
//private:
//	int num;
//	int age;
//	float score;
//};
//
//int main()
//{
//	Student stu[3]={Student(1001,18,71),Student(1002,19,78),Student(1003,20,98)};
//	int i_countx;
//	for(i_countx=0;i_countx<3;i_countx++)
//		stu[i_countx].total();
//	cout << "sum is:" << stu[1].sum << endl;
//	cout << "count is:" << Student::count << endl;
//	cout << "average is:" << Student::average() << endl;
//
//	system("pause");
//	return 0;
//}
//
//float Student::sum=0;
//float Student::count=0;
//
//void Student::total()
//{
//	count++;
//	sum += score;
//}
//
//float Student::average()
//{
//	return sum/count;
//}