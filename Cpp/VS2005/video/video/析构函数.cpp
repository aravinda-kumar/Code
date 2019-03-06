//#include <iostream>
//using namespace std;
//
//class CStu
//{
//public:
//	int age;
//	int *pp;
//	CStu ()
//	{
//		age = 12;
//		cout << "构造函数" << endl ;
//		pp = new int(12);
//	}
//
//	~CStu()
//	{
//		cout << "析构函数" <<endl;
//		delete pp;
//	}
//};
//
//int main()
//{
//	//{
//	//	CStu stu;
//	//}
//	//{
//	//	CStu *stu = new CStu;
//	//}
///*	CStu *stu = new CStu;
//	delete stu;*/						//指针对象遇到delete才会调用析构函数;
//	//CStu();								//临时对象  equal to CStu tu(12);
//	//									//临时对象作用域仅限于当前语句；
//	//int a =int(12);						//临时变量； equal to q = 12; a = q;
//	//CStu *stu =(CStu *)malloc(sizeof(CStu));
//	CStu *stu = new CStu;
//	delete stu;
//	//free(stu);
//
//	system("pause");
//	return 0;
//}