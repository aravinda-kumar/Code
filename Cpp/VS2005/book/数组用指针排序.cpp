//#include <iostream>
//using namespace std;
//
//void in1(int* p)
//{
//	int i;
//	cout << "Please input 10 numbers:";
//	for(i=0;i<10;i++)
//	{
//		cin >> *(p+i);
//	}
//	cout << endl;
//}
//
//void out1(int* p)
//{
//	int i;
//	cout << "The outcome is:";
//	for(i=0;i<10;i++)
//	{
//		cout << *(p+i) << "  ";
//	}
//	cout << endl;
//}
//
//void cmp(int* p)
//{
//	int i,j;
//	int tmp;
//	for(i=0;i<9;i++)
//	{
//		for(j=0;j<9;j++)
//		{
//			if( *(p+j) > *(p+j+1))
//			{
//				tmp = *(p+j); *(p+j) = *(p+j+1); *(p+j+1) = tmp;
//			}
//		}
//	}
//}
//
//int main()
//{
//	int a[10];
//	int a[10]={10,9,8,7,6,5,4,3,2,1};
//	int i;
//	int* p;
//	p = a;
//	in1(a);
//	cout << "The original number is:";
//	for(i=0;i<10;i++)
//	{
//		cout << a[i] << "  ";
//	}
//	cout << endl;
//	cmp(a);
//	out1(a);
//	cout << "The outcome is:";
//	for(i=0;i<10;i++)
//	{
//		cout << *(p+i) << "  ";
//	}
//	cout << endl;
//	system("pause");
//	return 0;
//}