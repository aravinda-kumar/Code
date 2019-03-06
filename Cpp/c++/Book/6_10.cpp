//#include <iostream>
//using namespace std;
//
//void sorted(int (*i_a)[5]);
//
//int main()
//{
//	int i_a[5][5]={12,14,56,11,33,123,-23,456,777,543,1,2,3,4,5,6,7,8,9,21,20,22,23,15,23};
//	int i_countx, i_county;
//	cout << "Oringinal:" << endl;
//	for(i_countx=0;i_countx<5;i_countx++)
//	{
//		for(i_county=0;i_county<5;i_county++)
//			cout << *(*(i_a+i_countx)+i_county) << '\t';
//		cout << endl;
//	}
//	sorted(i_a);
//	cout << "Sorted:" << endl;
//	for(i_countx=0;i_countx<5;i_countx++)
//	{
//		for(i_county=0;i_county<5;i_county++)
//			cout << *(*(i_a+i_countx)+i_county) << '\t';
//		cout << endl;
//	}
//	system("pause");
//	return 0;
//}
//
//void sorted(int (*i_a)[5])
//{
//	int i_countx,i_county;
//	int i_tmp;
//	int i_row,i_colum;
//	i_tmp = *(*(i_a+0)+0);
//	for(i_countx=0;i_countx<5;i_countx++)
//	{
//		for(i_county=0;i_county<5;i_county++)
//		{
//			if(i_tmp<*(*(i_a+i_countx)+i_county))
//			{
//				i_tmp=*(*(i_a+i_countx)+i_county);
//				i_row=i_countx;
//				i_colum=i_county;
//			}
//		}
//	}
//	i_tmp=*(*(i_a+2)+2);
//	*(*(i_a+2)+2)=*(*(i_a+i_row)+i_colum);
//	*(*(i_a+i_row)+i_colum)=i_tmp;
//
//	i_tmp = *(*(i_a+0)+0);
//	for(i_countx=0;i_countx<5;i_countx++)
//	{
//		for(i_county=0;i_county<5;i_county++)
//		{
//			if(i_tmp>*(*(i_a+i_countx)+i_county))
//			{
//				i_tmp=*(*(i_a+i_countx)+i_county);
//				i_row=i_countx;
//				i_colum=i_county;
//			}
//		}
//	}
//	i_tmp=*(*(i_a+0)+0);
//	*(*(i_a+0)+0)=*(*(i_a+i_row)+i_colum);
//	*(*(i_a+i_row)+i_colum)=i_tmp;
//
//	i_tmp = *(*(i_a+0)+1);
//	for(i_countx=0;i_countx<5;i_countx++)
//	{
//		for(i_county=0;i_county<5;i_county++)
//		{
//			if(i_countx==0 && i_county==0)
//				continue;
//			else
//			{
//				if(i_tmp>*(*(i_a+i_countx)+i_county))
//				{
//					i_tmp=*(*(i_a+i_countx)+i_county);
//					i_row=i_countx;
//					i_colum=i_county;
//				}
//			}
//		}
//	}
//	i_tmp=*(*(i_a+0)+4);
//	*(*(i_a+0)+4)=*(*(i_a+i_row)+i_colum);
//	*(*(i_a+i_row)+i_colum)=i_tmp;
//
//	i_tmp = *(*(i_a+0)+1);
//	for(i_countx=0;i_countx<5;i_countx++)
//	{
//		for(i_county=0;i_county<5;i_county++)
//		{
//			if(i_countx==0 && i_county==0 || i_countx==0 && i_county==4)
//				continue;
//			else
//			{
//				if(i_tmp>*(*(i_a+i_countx)+i_county))
//				{
//					i_tmp=*(*(i_a+i_countx)+i_county);
//					i_row=i_countx;
//					i_colum=i_county;
//				}
//			}
//		}
//	}
//	i_tmp=*(*(i_a+4)+0);
//	*(*(i_a+4)+0)=*(*(i_a+i_row)+i_colum);
//	*(*(i_a+i_row)+i_colum)=i_tmp;
//
//	i_tmp = *(*(i_a+0)+1);
//	for(i_countx=0;i_countx<5;i_countx++)
//	{
//		for(i_county=0;i_county<5;i_county++)
//		{
//			if(i_countx==0 && i_county==0 || i_countx==0 && i_county==4 || i_countx==4 && i_county==0)
//				continue;
//			else
//			{
//				if(i_tmp>*(*(i_a+i_countx)+i_county))
//				{
//					i_tmp=*(*(i_a+i_countx)+i_county);
//					i_row=i_countx;
//					i_colum=i_county;
//				}
//			}
//		}
//	}
//	i_tmp=*(*(i_a+4)+4);
//	*(*(i_a+4)+4)=*(*(i_a+i_row)+i_colum);
//	*(*(i_a+i_row)+i_colum)=i_tmp;
//}