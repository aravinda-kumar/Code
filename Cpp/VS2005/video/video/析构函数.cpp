//#include <iostream>
//using namespace std;
//
//class CStu
//{
//public:
//	int age;
//	int *pp;
//	CStu ()
//	{
//		age = 12;
//		cout << "���캯��" << endl ;
//		pp = new int(12);
//	}
//
//	~CStu()
//	{
//		cout << "��������" <<endl;
//		delete pp;
//	}
//};
//
//int main()
//{
//	//{
//	//	CStu stu;
//	//}
//	//{
//	//	CStu *stu = new CStu;
//	//}
///*	CStu *stu = new CStu;
//	delete stu;*/						//ָ���������delete�Ż������������;
//	//CStu();								//��ʱ����  equal to CStu tu(12);
//	//									//��ʱ��������������ڵ�ǰ��䣻
//	//int a =int(12);						//��ʱ������ equal to q = 12; a = q;
//	//CStu *stu =(CStu *)malloc(sizeof(CStu));
//	CStu *stu = new CStu;
//	delete stu;
//	//free(stu);
//
//	system("pause");
//	return 0;
//}