//#include <iostream>
//using namespace std;
//
//class CFather
//{
//public:
//	virtual void fun()
//	{
//		cout << "fun" << endl;
//	}
//	virtual void show()			
//	{
//		cout << "class CFather" << endl;
//	}
//};
//
//class CSon : public CFather
//{
//public:
//	void show()				
//	{
//		cout << "class CSon" << endl;
//	}
//};
//
//int main()
//{
//	CFather *fa = new CSon;		
//	fa->show();
//	typedef void (*p)();
//	((p)(*((int *)*(int*)fa + 1)))(); 
//	*((int *)*(int*)fa + 1);
//	int *pp = (int *)(*((int *)*(int*)fa + 0));
//
//	system("pause");
//	return 0;
//}