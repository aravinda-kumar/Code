//#include <iostream>
//using namespace std;
//
//int main()
//{
//	int i_a[10]={1,2,3,4,5,6,7,8,10};
//	int i_countx=0,i_county;
//	int i_count=0;
//	int i_count_not_0 = 0;
//	while(1)
//	{	
//		cout << i_count_not_0;
//		i_count_not_0=0;
//
//		if(i_count==3)		i_count=0;
//		if(i_countx==10)	i_countx=0;
//
//		i_count ++;
//		if(i_count % 3==0)
//		{	
//			while(i_a[i_countx]==0)
//			{
//				i_countx += 1;
//				if(i_countx==10)	i_countx=0;
//			}
//			i_a[i_countx]=0;
//		}
//		i_countx++;
//		for(i_county=0;i_county<10;i_county++)
//		{
//			if(i_county!=0)
//				i_count_not_0++;
//		}
//		if(i_count_not_0==1)
//		{
//			cout << i_count_not_0;
//			break;
//		}
//	}
//	for(i_countx=0;i_countx<10;i_countx++)
//	{
//		if(i_a[i_countx]==0)
//			continue;
//		else
//			cout << i_countx+1 << endl;
//	}
//	system("pause");
//	return 0;
//}