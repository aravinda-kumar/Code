//#include <iostream>
//using namespace std;
//
//class CGrandfather
//{
//public: 
//	CGrandfather(int a,int b)
//	{
//		cout << "I am grandfather class!" << endl;
//	}
//
//	CGrandfather(int c)
//	{
//
//	}
//};
//
//	/*ֻ����ֱ���¼����г�ʼ����������Խ��
//	*������캯������ͨ�������б�ĸ������������ĸ����캯����
//	*Ҳ����ֱ���ò�����ֵ���г�ʼ��
//	*/
//class CFather : public CGrandfather
//{
//public:
//	CFather(int a) : CGrandfather(a)
//	{
//		cout << "I am father class!" << endl;
//	}
//};
//
//class CSon : public CFather
//{
//public:
//	int b;
//
//	//����Ĺ��캯��ͨ������Ĺ��캯���Ĳ����б�����ʼ��
//	CSon() : CFather(1)  
//	{
//
//	}
//};
//
//int main()
//{
//	CSon son;
//
//	system("pause");
//	return 0;
//}