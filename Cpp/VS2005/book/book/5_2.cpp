//#include <iostream>
//using namespace std;
//
//int main()
//{
//	int i_a[10]={1,2,3,4,5,6,7,8,9,10};
//	int i_tmp;
//	int i_countx, i_county;
//	int i_chg;
//	for(i_countx=0;i_countx<10;i_countx++)
//	{
//		i_tmp = i_countx;
//		for(i_county=i_countx+1;i_county<10;i_county++)
//			if(i_a[i_tmp]<i_a[i_county])
//				i_tmp = i_county;
//		i_chg = i_a[i_countx];
//		i_a[i_countx] = i_a[i_tmp];
//		i_a[i_tmp] = i_chg;
//	}
//
//	for(i_tmp=0;i_tmp<10;i_tmp++)
//		cout << i_a[i_tmp] << ' ';
//	cout << endl;
//	system("pause");
//	return 0;
//}