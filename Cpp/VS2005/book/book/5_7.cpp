//#include <iostream>
//using namespace std;
//
//int main()
//{
//	int i_a[4][4]={1,12,3,35,6,7,52,34,56,11,16,78,234,54,77,90};
//	int i_countx,i_county,i_tmp;
//	int i_row,i_colum;
//	int flag=0;
//	for(i_countx=0;i_countx<4;i_countx++)
//	{
//		for(i_county=0;i_county<4;i_county++)
//			cout << i_a[i_countx][i_county] << '\t';
//		cout << endl;
//	}
//	for(i_countx=0;i_countx<4;i_countx++)
//	{
//		i_tmp=i_a[i_countx][0];
//		for(i_county=0;i_county<4;i_county++)
//		{
//			if(i_tmp<i_a[i_countx][i_county])
//			{
//				i_tmp=i_a[i_countx][i_county];
//				i_row=i_countx;
//				i_colum=i_county;
//			}
//		}
//		for(i_row=0;i_row<4;i_row++)
//		{
//			if(i_tmp>i_a[i_row][i_colum])
//				break;
//		}
//		if(i_row == 4)
//		{
//			cout << i_tmp << endl;
//			flag = 1;
//		}
//
//	}
//	if(flag == 0)
//		cout << "Doesn't exit!" << endl;
//	system("pause");
//	return 0;
//}