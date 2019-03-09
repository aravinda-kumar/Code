//#include<iostream>
//using namespace std;
//
//template <typename T1, typename T2>
//class CFather
//{
//public:
//	virtual void fun()
//	{
//		cout << "CFather" << endl;
//	}
//};
//
////参数列表要显式声明
////template <typename T1, typename T2>
//class CSon :public CFather<int, int>
//{
//public:
//	void fun()
//	{
//		cout << "CSon" << endl;
//	}
//};
//
//
//int main()
//{
//	//参数列表要相同
//	CFather<int, int> *pf = new CSon;
//	pf->fun();
//
//	system("pause");
//	return 0;
//}