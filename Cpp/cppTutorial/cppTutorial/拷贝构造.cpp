//#define _CRT_SECURE_NO_WARNINGS
//#include<iostream>
//using namespace std;
//
//class CStu
//{
//public:
//	int *a;
//	CStu()
//	{
//		a = new int[3]{ 1,2 };
//	}
//	CStu(const CStu &stu)
//	{
//		//���
//		this->a = new int[3];
//		//this->a[0] = stu.a[0];
//		//this->a[1] = stu.a[1];
//		//this->a[2] = stu.a[2];
//		//�������������ֽ���
//		memcpy(this->a, stu.a, sizeof(int[3]));
//	}
//	~CStu()
//	{
//		delete[] a;
//	}
//};
//
//int main()
//{
//	{
//		CStu st;
//		cout << st.a[0] << ' ' << st.a[1] << ' ' << st.a[2] << endl;
//		cout << st.a << endl;
//
//		//ɾ���ڶ���ָ���ʱ��������ж�
//		CStu at = st;
//		cout << at.a[0] << ' ' << at.a[1] << ' ' << at.a[2] << endl;
//		cout << at.a << endl;
//
//		//at.a == st.a
//	}
//
//	system("pause");
//	return 0;
//}