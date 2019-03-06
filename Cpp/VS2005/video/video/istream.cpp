//#include <iostream>
//using namespace std;
//
//class Cstu
//{	
//private:
//	int age;
//	double height;
//public:
//	Cstu()
//	{
////		age = 12;
////		height = 12.345;
//	}
//	friend istream& operator >>(istream& ist,  Cstu& st);
//	void show()
//	{
//		cout << age << endl;
//		cout << height << endl;
//	}
//};
//
//istream& operator >>(istream& ist,  Cstu& st)
//{
//	ist >> st.age;
//	ist >> st.height;
//	if (ist.fail())
//	{
//		st.age = 0;
//		st.height = 0;
//	}
//	return ist;
//}
//int main()
//{
//	Cstu st;
//	cin >> st;
//	st.show();
//
//	system("pause");
//	return 0;
//}