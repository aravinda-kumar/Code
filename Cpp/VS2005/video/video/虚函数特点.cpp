//#include <iostream>
//using namespace std;
//
////�飺ֻ��Ժ�����Ա�������ݳ�Աû��Ч����
////��д����麯����
//class CFather
//{
//public:
//	virtual void show()			
//	{
//		cout << "class CFather" << endl;
//	}
//};
//
//class CSon : public CFather
//{
//public:
//	int aa;
//	void show()		//�������麯�� voidǰ��Ĭ����virtual			
//	{
//		cout << "class CSon" << endl;
//	}
//};
//
//class CSonson : public CSon
//{
//public:
//	int aa;
//	void show()				
//	{
//		cout << "class CSonson" << endl;
//	}
//};
//
//int main()
//{
//	CFather *fa = new CSon;		
//	fa->show();  
//	CSon *so = new CSonson;
//	so ->show();		//��ʾclass Csonson
//
//	system("pause");
//	return 0;
//}