//#include <iostream>
//using namespace std;
//
////�麯����ǰ���Ǻ�������Ҫ��ͬ
//
//class CFather
//{
//public:
//	virtual void show()			//����������ͬ
//	{
//		cout << "class CFather" << endl;
//	}
//};
//
//class CSon : public CFather
//{
//public:
//	int aa;
//	void show()					//����������ͬ
//	{
//		cout << "class CSon" << endl;
//	}
//};
//
//class CSon1 : public CFather
//{
//public:
//	int aa;
//	void show()					//����������ͬ
//	{
//		cout << "class CSon1" << endl;
//	}
//};
//
//int main()
//{
//	CFather *fa = new CSon1;		//������࣬����ָ��ָ��˭�͵���˭��
//	fa->show();  //���಻���麯��ֻ�ܵ��ø���ĳ�Ա��
//				 //�������麯�����õ�������ĳ�Ա��
//				 //�����ָ���������ĳ�Ա��
//	system("pause");
//	return 0;
//}