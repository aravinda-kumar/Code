//#include <iostream>
//using namespace std;
//
//class Cstu
//{
//public:
//	Cstu() 		//���캯����������������Ϊ��������
//	{
//		a = 12;
//	}
//
//	~Cstu() //Cstu* this;
//	{
//
//	}
//	int a;
//
//	void show() const //const Cstu* this;
//	{
//		//a = 13;  //�����������޸����ݳ�Ա��
//		int b = 12; //�������ڲ����Զ������ݳ�Ա���ҿ����޸�
//		cout << "I am show!" << endl;
//		cout << a*12 << endl; //�������п��Բ������ݳ�Ա
//	}
//
//	void fun()
//	{
//		cout << "I am fun!" << endl;
//	}
//};
//
//int main()
//{
//	Cstu st;		//��ͨ����ȿ��Ե��ó�����Ҳ���Ե�����ͨ������
//	st.show();
//	st.fun();
//
//	const Cstu st1;	//������ֻ�ܵ��ó�������
//	st1.show();
//
//	system("pause");
//	return 0;
//}