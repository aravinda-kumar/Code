//#include <iostream>
//using namespace std;
//
////�����������к͸�������ͬ�����ݳ�Ա�������ֵ�Ḳ�ǵ���������ݳ�Ա��
////�����е�������ϸ���������򻹿��Ե��ø����е����ݳ�Ա��
//
//class CFather
//{
//public:
//	int a;
//	int b;
//	CFather()
//	{
//		a = 12;
//		b = 13;
//	}
//
//	friend void show();
//
//	void fun(int a)
//	{
//		cout << "CFatherfun()" << endl;
//	}
//};
//
//
//
//class CSon : public CFather
//{
//private:
//	int c;
//public:
//	int a;
//	CSon()
//	{
//		a = 10;
//	}
//
//	void fun()
//	{
//		cout << "CSonfun()" << endl;
//	}
//};
//
////�������Ԫ�����������������Ԫ������
////��Ԫ���������Ա��̳У�
//void show()
//{
//	CSon ft;
//	cout << ft.c << endl;
//}
//
//int main()
//{
//	CSon so;
//	so.fun();
//	//so.fun(1); �������������ͬ����������һ���в�����ʱ�����߲������غ�����
//	so.CFather :: fun(1);
//	//�������ͬ����Ҫ���������������֣�
//	cout << so.a << endl;
//	cout << so.CFather :: a << endl;
//
//	system("pause");
//	return 0;
//}