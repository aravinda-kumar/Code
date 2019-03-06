//#include <iostream>
//using namespace std;
//
//class student
//{
//public:
//	student(int a,int b,int c):num(a),age(b),score(c){}
//	void sunmmary();
//	static float aver();
//private:
//	int num;
//	int age;
//	int score;
//	static float sum;
//	static float count;
//};
//
//float student :: sum = 0;
//float student :: count = 0;
//
//void student :: sunmmary()
//{
//	sum = sum + score;
//	count ++;
//}
//
//float student :: aver()
//{
//	return (sum/count);
//}
//
//int main()
//{
//	student stu[3]={ student (1001,18,70),student (1002,19,78), student (1005,20,99)};
//	int i;
//	for(i=0;i<3;i++)
//		stu[i].sunmmary();
//	cout << "The average is:" << student :: aver() << endl;
//	system("pause");
//	return 0;
//}