//#include <iostream>
//using namespace std;
//
//int main()
//{
//	int c_ch[10][10]={{1},{1,1}};
//	int i_countx, i_county;
//	for(i_countx=0;i_countx<10;i_countx++)
//	{
//		c_ch[i_countx][0]=1;
//		c_ch[i_countx][i_countx]=1;
//	}
//	for(i_countx=2;i_countx<10;i_countx++)
//	{
//		for(i_county=1;i_county<i_countx;i_county++)
//		{
//			c_ch[i_countx][i_county]=c_ch[i_countx-1][i_county-1]+c_ch[i_countx-1][i_county];
//		}
//	}
//	for(i_countx=0;i_countx<10;i_countx++)
//	{
//		for(i_county=0;i_county<=i_countx;i_county++)
//			cout << c_ch[i_countx][i_county] << ' ';
//		cout << endl;
//	}
//	cout << endl;
//	system("pause");
//	return 0;
//}