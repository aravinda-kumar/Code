//#include <iostream>
//using namespace std;
//
//void average_fir(int (*p_stu)[6]);
//void fail_2(int (*p_stu)[6]);
//void success_90(int (*p_stu)[6]);
//
//int main()
//{
//	int i_stu[4][6]={{1001,85,90,86,95,88},{1002,56,40,87,66,70},
//					 {1003,44,23,44,56,60},{1004,90,100,80,100,100}};
//	
//	average_fir(i_stu);
//	fail_2(i_stu);
//	success_90(i_stu);
//		
//	system("pause");
//	return 0;
//}
//
//void average_fir(int (*p_stu)[6])
//{
//	double d_sum=0;
//
//	int i_countx;
//	for(i_countx=0;i_countx<4;i_countx++)
//		d_sum += *(*(p_stu+i_countx)+1);
//	
//	cout << "The average score of first subject is:" << d_sum/4 << endl;
//}
//
//void fail_2(int (*p_stu)[6])
//{
//	int i_countx,i_county;
//	int i_count=0;
//	for(i_countx=0;i_countx<4;i_countx++)
//	{
//		for(i_county=1;i_county<6;i_county++)
//		{
//			if(*(*(p_stu+i_countx)+i_county)<60)
//				i_count++;
//		}
//		if(i_count>2)
//		{	
//			cout << "The number and scores of Student failed in the exam are:";
//			for(i_county=0;i_county<6;i_county++)
//				cout << *(*(p_stu+i_countx)+i_county) << ' ';
//			cout << endl;
//		}
//		i_count=0;
//	}
//}
//
//void success_90(int (*p_stu)[6])
//{
//	double d_sum = 0;
//	int i_countx,i_county;
//	int i_count=0;
//	for(i_countx=0;i_countx<4;i_countx++)
//	{
//		for(i_county=1;i_county<6;i_county++)
//		{
//			d_sum += *(*(p_stu+i_countx)+i_county);
//			if(*(*(p_stu+i_countx)+i_county)>90)
//				i_count++;
//		}
//		if(i_count==5 || d_sum/5>85)
//		{
//			cout << "The number and scores of Student succeed in the exam are:";
//			for(i_county=0;i_county<6;i_county++)
//				cout << *(*(p_stu+i_countx)+i_county) << ' ';
//			cout << endl;	
//		}
//		i_count=0;
//		d_sum=0;
//	}
//}