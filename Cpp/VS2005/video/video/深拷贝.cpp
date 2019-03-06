//#include <iostream>
//#include <cstring>
//using namespace std;
//
//class Cstu
//{
//public:
//	int *a;
//	Cstu()
//	{
//		a = new int[2];
//		a[0] = 12;
//		a[1] = 13;
//	}
//		
//	Cstu(const Cstu& b)
//	{
//		//this ->a = b.a;
//		this ->a = new int[2];
//		this->a[0] = b.a[0];
//		this->a[1] = b.a[1];
//	}
//
//	~Cstu()
//	{
//		delete[] a;
//	}
//
//};
//
//int main()
//{
//	{
//		Cstu at;
//		cout << at.a[0] << "  " << at.a[1] << endl;
//
//		Cstu st = at;
//		cout << st.a[0] << "  " << st.a[1] << endl;
//	}
//
//	system("pause");
//	return 0;
//}