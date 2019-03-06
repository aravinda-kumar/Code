//#include <iostream>
//using namespace std;
//
//void move_10(int *i_a, int i_num);
//
//int main()
//{
//	int i_a[10]={1,2,3,4,5,6,7,8,9,10};
//	int i_countx;
//	
//	move_10(i_a, 3);
//
//	for(i_countx=0;i_countx<10;i_countx++)
//		cout << i_a[i_countx] << ' ';
//	cout << endl;
//
//	system("pause");
//	return 0;
//}
//
//void move_10(int *i_a, int i_num)
//{
//	int i_countx, i_count;
//	int i_tmp;
//
//	for(i_countx=0;i_countx<3;i_countx++)
//	{
//		i_tmp = *(i_a+9);
//		for(i_count=9;i_count>0;i_count--)
//			*(i_a+i_count)=*(i_a+i_count-1);
//		*(i_a+0)=i_tmp;
//	}
//}