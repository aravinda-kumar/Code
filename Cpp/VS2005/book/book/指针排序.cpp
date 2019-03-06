//#include <iostream>
//using namespace std;
//
//void sorted_10(int *ip_a, int i_num);
//
//int main()
//{
//	int i_a[10];
//	int *ip_a;
//	ip_a = i_a;
//	cout << "10 numbers:" << endl;
//	int i_countx;
//	for(i_countx=0;i_countx<10;i_countx++)
//		cin >> *(ip_a+i_countx);
//
//	sorted_10(ip_a, 10);
//
//	cout << "sorted:" << endl;
//	for(ip_a=i_a;ip_a<i_a+10;ip_a++)
//		cout << *(ip_a) << ' ';
//	cout << endl;
//
//	system("pause");
//	return 0;
//}
//
//void sorted_10(int *ip_a, int i_num)
//{
//	int i_countx, i_county;
//	int i_tmp;
//	int i_count;
//	for(i_countx=0;i_countx<i_num;i_countx++)
//	{
//		i_count = i_countx;
//		for(i_county=i_countx+1;i_county<i_num;i_county++)
//		{
//			if(*(ip_a+i_count)>*(ip_a+i_county))
//			{
//				i_count=i_county;
//			}
//		}
//		if(i_count!=i_countx)
//		{
//			i_tmp=*(ip_a+i_countx);
//			*(ip_a+i_countx)=*(ip_a+i_count);
//			*(ip_a+i_count)=i_tmp;
//		}
//	}
//}