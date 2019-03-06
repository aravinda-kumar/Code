//#include <iostream>
//using namespace std;
//
////虚：只针对函数成员，对数据成员没有效果；
////重写针对虚函数；
//class CFather
//{
//public:
//	virtual void show()			
//	{
//		cout << "class CFather" << endl;
//	}
//};
//
//class CSon : public CFather
//{
//public:
//	int aa;
//	void show()		//本身是虚函数 void前面默认有virtual			
//	{
//		cout << "class CSon" << endl;
//	}
//};
//
//class CSonson : public CSon
//{
//public:
//	int aa;
//	void show()				
//	{
//		cout << "class CSonson" << endl;
//	}
//};
//
//int main()
//{
//	CFather *fa = new CSon;		
//	fa->show();  
//	CSon *so = new CSonson;
//	so ->show();		//显示class Csonson
//
//	system("pause");
//	return 0;
//}