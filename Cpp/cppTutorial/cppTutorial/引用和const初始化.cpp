//#include<iostream>
//using namespace std;
//
//struct STU
//{
//	int a;
//	float b;
//};
//
//class CStu
//{
//public:
//	int nAge;
//	CStu()
//	{
//		cout << "构造函数" << endl;
//	}
//
//	CStu(int a):nAge(a)
//	{
//		cout << "构造函数" << endl;
//	}
//
//	~CStu()
//	{
//		cout << "析构函数" << endl;
//	}
//};
//
//int main()
//{
//	////临时对象
//	//CStu(12);	//作用域仅限当前所在的语句
//
//	CStu *stu = (CStu *)malloc(sizeof(CStu));
//
//	free(stu);
//
//
//	system("pause");
//	return 0;
//}