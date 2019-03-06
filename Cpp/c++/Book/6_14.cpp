//#include <iostream>
//using namespace std;
//
//void reverse_sorted(int *p_a ,int i_num);
//
//int main()
//{
//	int i_a[7]={0,1,2,3,4,5,6};
//	int i_countx;
//	for(i_countx=0;i_countx<7;i_countx++)
//		cout << *(i_a+i_countx) << ' ';
//	cout << endl;
//
//	reverse_sorted(i_a, 7);
//	
//	for(i_countx=0;i_countx<7;i_countx++)
//		cout << *(i_a+i_countx) << ' ';
//	cout << endl;
//
//	system("pause");
//	return 0;
//}
//
//void reverse_sorted(int *p_a ,int i_num)
//{
//	int i_countx;
//	int i_tmp;
//	for(i_countx=0;i_countx<i_num/2-1;i_countx++)
//	{
//		i_tmp=*(p_a+i_countx);
//		*(p_a+i_countx)=*(p_a+i_num-i_countx-1);
//		*(p_a+i_num-i_countx-1)=i_tmp;
//	}
//}