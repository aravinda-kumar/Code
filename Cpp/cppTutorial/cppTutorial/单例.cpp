//#include <iostream>
//using namespace std;
//
//class CFather
//{
//private:
//	CFather()
//	{
//
//	}	
//public:
//	static int flag;
//	static CFather* CreateObj()
//	{
//		if (1 == flag)
//		{
//			flag = 0;
//			return (new CFather);
//		}
//		else
//		{
//			return NULL;
//		}
//	}
//
//	~CFather()
//	{
//		flag = 1;
//	}
//};
//
//int CFather::flag = 1;
//
//int main()
//{
//	CFather *pf = CFather::CreateObj();
//	delete pf;
//	CFather *pf1 = CFather::CreateObj();
//
//	system("pause");
//	return 0;
//}