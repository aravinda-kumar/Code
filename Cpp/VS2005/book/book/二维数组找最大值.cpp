//#include <iostream>
//using namespace std;
//
//int max_value(int i_a[][4]);
//
//int main()
//{
//	int i_a[3][4]={5,12,23,56,19,28,37,46,-12,-34,6,8};
//	cout << "The biggest number is:" << max_value(i_a) << endl;
//	 cout << "It is in NO." << i_row+1 << " row, and NO." << i_colum+1 << " colum." << endl; 
//	system("pause");
//	return 0;
//}
//
//int max_value(int i_a[3][4])
//{
//	int i_countx,i_county,i_row,i_colum,i_max;
//	i_max = i_a[0][0];
//	for (i_countx=0;i_countx<3;i_countx++)
//	{
//		for (i_county=0;i_county<4;i_county++)
//		{
//			if(i_max < i_a[i_countx][i_county])
//			{
//				i_max = i_a[i_countx][i_county];
//				i_row = i_countx;
//				i_colum = i_county;
//			}
//		}
//	}
//	return i_max;
//}