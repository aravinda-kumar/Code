//#include <iostream>
//using namespace std;
//
//void transposition_3(int (*i_a)[3]);
//
//int main()
//{
//	int i_a[][3]={1,2,3,4,5,6,7,8,9};
//	int i_countx,i_county;
//	transposition_3(i_a);
//	for(i_countx=0;i_countx<3;i_countx++)
//	{
//		for(i_county=0;i_county<3;i_county++)
//			cout << *(*(i_a+i_countx)+i_county) << ' ';
//		cout << endl;
//	}
//
//	system("pause");
//	return 0;
//}
//
//void transposition_3(int (*i_a)[3])
//{
//	int i_countx,i_county;
//	int i_tmp;
//	for(i_countx=0;i_countx<3;i_countx++)
//	{
//		for(i_county=i_countx;i_county<3;i_county++)
//		{
//			i_tmp = *(*(i_a+i_countx)+i_county);
//			*(*(i_a+i_countx)+i_county)=*(*(i_a+i_county)+i_countx);
//			*(*(i_a+i_county)+i_countx)=i_tmp;
//		}
//	}
//}