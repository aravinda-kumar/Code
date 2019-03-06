//#include <iostream>
//using namespace std;
//
//class CGrandfather
//{
//public: 
//	CGrandfather(int a,int b)
//	{
//		cout << "I am grandfather class!" << endl;
//	}
//
//	CGrandfather(int c)
//	{
//
//	}
//};
//
//	/*只可以直属下级进行初始化，不可以越级
//	*多个构造函数重载通过参数列表的个数决定调用哪个构造函数；
//	*也可以直接用参数左值进行初始化
//	*/
//class CFather : public CGrandfather
//{
//public:
//	CFather(int a) : CGrandfather(a)
//	{
//		cout << "I am father class!" << endl;
//	}
//};
//
//class CSon : public CFather
//{
//public:
//	int b;
//
//	//父类的构造函数通过子类的构造函数的参数列表来初始化
//	CSon() : CFather(1)  
//	{
//
//	}
//};
//
//int main()
//{
//	CSon son;
//
//	system("pause");
//	return 0;
//}