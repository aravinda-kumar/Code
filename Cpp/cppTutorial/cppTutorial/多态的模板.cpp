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
////�����б�Ҫ��ʽ����
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
//	//�����б�Ҫ��ͬ
//	CFather<int, int> *pf = new CSon;
//	pf->fun();
//
//	system("pause");
//	return 0;
//}