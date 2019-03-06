//#include <iostream>
//using namespace std;
//
//void sorted_10p(int **ipp_a);
//
//int main()
//{
//	int i_a[10]={1,2,3,4,5,6,7,8,9,10};
//	int *ip_a[10];
//	int **ipp_a;
//	int i_countx;
//	for(i_countx=0;i_countx<10;i_countx++)
//		ip_a[i_countx]=&i_a[i_countx];
//	ipp_a=ip_a;
//	for(i_countx=0;i_countx<10;i_countx++)
//		cout << *(*(ipp_a+i_countx)) << ' ';
//	cout << endl;
//
//	sorted_10p(ipp_a);
//	
//	for(i_countx=0;i_countx<10;i_countx++)
//		cout << *(*(ipp_a+i_countx)) << ' ';
//	cout << endl;
//	
//	for(i_countx=0;i_countx<10;i_countx++)
//		cout << i_a[i_countx] << ' ';
//	cout << endl;
//
//	system("pause");
//	return 0;
//}
//
//void sorted_10p(int **ipp_a)
//{
//	int i_countx,i_county,i_count;
//	int *i_tmp;
//
//	for(i_countx=0;i_countx<9;i_countx++)
//	{
//		i_count=i_countx;
//		for(i_county=i_countx+1;i_county<10;i_county++)
//			if(*(*(ipp_a+i_count))<*(*(ipp_a+i_county)))
//				i_count=i_county;
//		if(i_count!=i_countx)
//		{
//			i_tmp=*(ipp_a+i_countx);
//			*(ipp_a+i_countx)=*(ipp_a+i_count);
//			*(ipp_a+i_count)=i_tmp;
//		}
//	}
//}