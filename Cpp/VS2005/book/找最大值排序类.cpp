//#include <iostream>
//using namespace std;
//
//class arr
//{
//public:
//	void set();
//	void max();
//	void show();
//private:
//	int a[10];
//};
//
//void arr :: set()
//{
//	int i;
//	for(i=0;i<10;i++)
//		cin >> a[i];
//}
//
//void arr :: max()
//{
//	int i,j;
//	int tmp;
//	for(i=0;i<9;i++)
//	{
//		for(j=0;j<9;j++)
//		{
//			if(a[j]<a[j+1])
//			{
//				tmp = a[j];
//				a[j] = a[j+1];
//				a[j+1] = tmp;
//			}
//		}
//	}
//}
//
//void arr :: show()
//{
//	int i;
//	for(i=0;i<10;i++)
//		cout << a[i] << "  " ;
//	cout << endl;
//}
//
//int main()
//{
//	arr a;
//	a.set();
//	a.max();
//	a.show();
//	system("pause");
//	return 0;
//}