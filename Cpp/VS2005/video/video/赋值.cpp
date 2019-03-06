//#include <iostream>
//using namespace std;
//
//class Cstu
//{	
//public:
//	int age;
//	double height;
//public:
//	Cstu()
//	{
//		age = 12;
//		height = 12.345;
//	}
//	int operator = (int a)  // must be in the class;
//	{
//		age = a;
//		return age;
//	}
//};
//
//Cstu& operator +=(Cstu& st1, int a)
//{
//	st1.age = st1.age + a;
//	
//	return (st1);
//}
//
//int main()
//{
//	Cstu st;
//	int a = 1;
//	cout << (st=111) << endl;
//	st += a += 111;
//	cout << st.age << endl;
//	system("pause");
//	return 0;
//}