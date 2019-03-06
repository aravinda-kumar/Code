//#include <iostream>
//using namespace std;
//
////有纯虚函数的类必须用子类重写该纯虚函数，才能实例化对象；
//class CFather	//接口类
//{
//public:
//	virtual void fun() = 0;
//	virtual void gun() = 0;
//	virtual ~CFather() = 0;
//};
//
//class CSon : public CFather
//{
//public:
//	void fun()
//	{
//		cout << "CSon" << endl;
//	}
//};
//
//int main()
//{
//	//此处仍然不可以用CFather进行定义对象，只可以用子类；
// //	CSon pf;
//
//	system("pause");
//	return 0;
//}