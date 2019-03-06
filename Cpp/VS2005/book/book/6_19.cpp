//#include <iostream>
//using namespace std;
//
//int main()
//{
//	char *cp_month[12]={"January","February","March","April","May","June","July","August","September","October","November","December"};
//	char **p;
//	char *p_tmp;
//	int i_countx,i_county,i_count;
//	p = cp_month;
//	for(i_countx=0;i_countx<11;i_countx++)
//	{
//		i_count=i_countx;
//		for(i_county=i_countx+1;i_county<12;i_county++)
//			if(strcmp(*(p+i_count),*(p+i_county))>0)
//				i_count=i_county;
//		if(i_count!=i_countx)
//		{
//			p_tmp = *(p+i_count);
//			*(p+i_count)=*(p+i_countx);
//			*(p+i_countx)=p_tmp;
//		}
//	}
//	for(i_countx=0;i_countx<12;i_countx++)
//		cout << *(p+i_countx) << endl;
//
//	system("pause");
//	return 0;
//}