//#include <iostream>
//using namespace std;
//
//class COut
//{
//public:
//	int a;
//	COut() :in(this)
//	{
//		a = 12;
//	}
//public:
//	class CIn
//	{
//	public:
//		int b;
//		COut *out;
//		CIn(COut *pf)
//		{
//			out = pf;
//			b = 13;
//		}
//		void funin()
//		{
//			//COut out;
//			cout << out->a << endl;
//		}
//	};
//public:
//	CIn in;
//};
//
//int main()
//{
//	COut ou;
//	ou.a = 15;
//	ou.in.funin();
//
//
//	system("pause");
//	return 0;
//}