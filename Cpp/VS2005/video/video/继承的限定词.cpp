//#include <iostream>
//using namespace std;
//
//class CPeople
//{
//private:
//	void fun1()
//	{
//		cout << "father fun1(); private" << endl;
//	}
//
//protected:
//	void fun2()
//	{
//		cout << "father fun2(); protected" << endl;
//	}
//
//public:
//	void fun3()
//	{
//		cout << "father fun3() public" << endl;
//	}
//};
////public ������ô�����������ô��
////protected �̳�֮�󣬸����public������protected �����е�protected��private����
////private �̳�֮��ȫ���private
//class CXiaoMing :private CPeople
//{
//public: 
//	int a;
//	void fun4()
//	{
////		fun1();
//	}
//};
//
//class CXiaohua : public CXiaoMing
//{
//	void fun5()
//	{
////		fun3();
//	}
//};
//
//int main()
//{
////	CXiaoMing xm;
////	xm.fun3();
//	//xm.fun3();
//	//xm.fun1();
////	CPeople cpo;
//	//cpo.fun3();
//
//	system("pause"); 
//	return 0;
//}