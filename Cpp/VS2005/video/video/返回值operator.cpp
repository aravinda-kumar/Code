//#include <iostream>
//using namespace std;
//
//class Cstu
//{
//public:
//	int age;
//	double score;
//
//	Cstu()
//	{
//		age = 12;
//		score = 12.12;
//	}
//};
//
//int operator + (Cstu& st, int n)
//{
//	st.age = st.age + n;
//	return st.age;
//}
//
//int operator + (Cstu& st1, Cstu& st2)
//{
//	st1.age = st1.age + st2.age;
//	return st1.age;
//}
//
//int operator + (int n, Cstu& st)
//{
//	st.age = st.age + n;
//	return st.age;
//}
//
//
//int main()
//{
//	Cstu st1;
//	Cstu st2;
//	st1.age = st1 + 13 + 13 + st2 + st2 +12 ;
//	cout << (st1.age);
//	system("pause");
//	return 0;
//}