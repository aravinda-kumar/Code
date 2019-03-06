//#include <strstream>
//#include <iostream>
//using namespace std;
//
//int main()
//{
//	char c[50]="12 34 65 -23 -32 33 61 99 321 32";
//	int a[10];
//	strstream strin(c, sizeof(c));
//	int i,j,k;
//	for(i=0;i<10;i++)
//		strin >> a[i];
//
//	cout << "Array a:";
//	for(i=0;i<10;i++)
//		cout << a[i] << ' ';
//	cout << endl;
//	int tmp=0;
//	for(i=0;i<9;i++)
//	{
//		for(j=i+1;j<10;j++)
//		{
//			if(a[tmp]>a[j])
//				tmp = j;
//		}
//		k=a[tmp]; a[tmp]=a[i]; a[i]=k;
//	}
//	
//	strstream strout(c,sizeof(c));
//	for (i=0;i<10;i++)
//		strout << a[i] << ' ';
//	strout << ends;
//	cout << "new Array c:" << c << endl;
//
//	system("pause");
//	return 0;
//}