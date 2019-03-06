//#include <iostream>
//using namespace std;
//
//class Student
//{
//	friend void fun(Student &stu);
//public:
//	Student(int n, float s):num(n),score(s){}
//	void change(int n, float s)
//	{
//		num = n;
//		score = s;
//	}
//	void display()
//	{
//		cout << num << " " << score << endl;
//	}
//private:
//	int num;
//	float score;
//};
//
//int main()
//{
//	Student stud(101,78.5);
//	stud.display();
//
//	fun(stud);
//
//	stud.display();
//
//	system("pause");
//	return 0;
//}
//
//void fun(Student &stu)
//{
//	stu.change(101,80.5);
//	stu.display();
//}