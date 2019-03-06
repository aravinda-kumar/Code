//#include <iostream>
//using namespace std;
//
////继承中的析构函数从子类向父类调用；
//
//class CGrandfather
//{
//public: 
//	CGrandfather()
//	{
//		cout << "Grandfather" << endl;
//	}
//
//	~CGrandfather()
//	{
//		cout << "grandfather" << endl;
//	}
//};
//
//class CFather : public CGrandfather
//{
//public:
//	CFather()
//	{
//		cout << "Father " << endl;
//	}
//	~CFather()
//	{
//		cout << "father " << endl;
//	}
//};
//
//class CSon : public CFather
//{
//public:
//	int b;
//	CSon() 
//	{
//		cout << "Son" << endl;
//	}
//	~CSon() 
//	{
//		cout << "son" << endl;
//	}
//};
//
//int main()
//{
//	{
//		CSon so;
//	}
//	system("pause");
//	return 0;
//}