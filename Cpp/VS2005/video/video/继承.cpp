//#include <iostream>
//using namespace std;
//
//class CPeople   //fundemental class  or father class
//{
//public:
//	void study()
//	{
//		cout << "study" << endl;
//	}
//};
//
//class CChild : public CPeople
//{
//public:
//	void Gotoschool()
//	{
//		study();
//		cout << "Gotoschool" << endl;
//	}
//};
//
//class CMan : public CPeople
//{
//public:
//	void Gotowork()
//	{
//		cout << "Gotowork" << endl;
//	}
//};
//
//class COld : public CPeople
//{
//public:
//	void Gotopark()
//	{
//		cout << "Gotopark" << endl;
//	}
//};
//
//int main()
//{
//	CChild child;
//	child.Gotoschool();
//
//	CChild * child1 = new CChild;
//	child1 ->Gotoschool();
//	system("pause");
//	return 0;
//}