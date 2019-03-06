//#include <iostream>
//using namespace std;
//
////虚函数的前提是函数名称要相同
//
//class CFather
//{
//public:
//	virtual void show()			//函数名称相同
//	{
//		cout << "class CFather" << endl;
//	}
//};
//
//class CSon : public CFather
//{
//public:
//	int aa;
//	void show()					//函数名称相同
//	{
//		cout << "class CSon" << endl;
//	}
//};
//
//class CSon1 : public CFather
//{
//public:
//	int aa;
//	void show()					//函数名称相同
//	{
//		cout << "class CSon1" << endl;
//	}
//};
//
//int main()
//{
//	CFather *fa = new CSon1;		//多个子类，父类指针指向谁就调用谁；
//	fa->show();  //父类不是虚函数只能调用父类的成员；
//				 //父类是虚函数调用的是子类的成员；
//				 //父类的指针调用子类的成员；
//	system("pause");
//	return 0;
//}