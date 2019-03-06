//#include <iostream>
//using namespace std;
//
//int main()
//{
//	int i_a[15]={1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
//	int i_in = 15;
//	int i_countx;
//	int i_start;
//	int i_pos;
//	if(i_in == i_a[15/2])
//		i_pos=15/2;
//	else
//	{
//		if(i_in < i_a[15/2])
//			i_start=0;
//		else
//			i_start=15/2;
//	}
//	for(i_countx=0+i_start;i_countx<7+i_start+1;i_countx++)
//	{
//		if(i_in == i_a[i_countx])
//		{
//			i_pos = i_countx+1;
//			break;
//		}
//	}
//	if(i_countx==7+i_start+1)
//		i_pos=-1;
//	if(i_pos==-1)
//		cout << "Doesn't exist!";
//	else
//		cout << "No." << i_pos << endl;
//	system("pause");
//	return 0;
//}