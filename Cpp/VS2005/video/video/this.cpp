//#include <iostream>
//using namespace std;
///*************************************
//thisָ��ֻ������ĺ�����ʹ�ã�
//*************************************/
//class CStu
//{
//public:
//	int a;
//	CStu (int a)
//	{
//		this -> a = a;   //this = &CStu;
//		this -> show();	 //thisָ�벻�ǳ�Ա�������Ա����������������
//	}
//
//	void show()
//	{
//		cout << a << endl;
//	}
//
//	CStu* GetAddr()
//	{
//		return this;
//	}
//};
//
//int main()
//{
//	CStu st(12);			//���󴴽�֮������thisָ�룻
//	st.show();
//	CStu* p = st.GetAddr();
//	cout << p << endl;      
//
//	CStu st1(13);
//	st1.show();
//	CStu* p1 = st.GetAddr();
//	cout << p1 << endl;
//
//	system("pause");
//	return 0;
//}