//#include <iostream>
//using namespace std;
//
//class Cstu
//{
//public:
//	int Age;
//
//	Cstu()
//	{
//		Age = 12;
//	}
//
//	int operator ++ ()
//	{
//		Age = Age + 1;
//		return Age;
//	}
//	int operator -- ()
//	{
//		Age = Age - 1;
//		return Age;
//	}
//	int operator ++ (int n)	// "int n" is a flag; 
//	{
//		n = Age;
//		Age = Age + 1;
//		return n;
//	}
//	int operator -- (int n)	// "int n" is a flag; 
//	{
//		n = Age;
//		Age = Age - 1;
//		return n;
//	}
//};
//
////int operator ++ (Cstu& st)
////{
////	st.Age = st.Age + 1;
////	return st.Age;
////}
//
////int operator ++ (Cstu &st,int n)	// "int n" is a flag; 
////{
////	n = st.Age;
////	st.Age = st.Age + 1;
////	return n;
////}
//
//int main()
//{
//	Cstu st;
//	cout << ++st << endl;;
//	cout << --st << endl;
//	cout << st++ << endl;
//	cout << st.Age << endl;
//	cout << st-- << endl;
//	cout << st.Age << endl;
//	system("pause");
//	return 0;
//}