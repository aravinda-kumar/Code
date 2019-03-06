//#include <iostream>
//using namespace std;
//
//int main()
//{
//	int i_a[11]={1,2,3,4,6,7,8,9,10,11};
//	int i_in = 8;
//	int i_countx, i_county;
//	for(i_countx=0;i_countx<10;i_countx++)
//	{
//		if(i_a[i_countx]<=i_in && i_a[i_countx+1]>=i_in)
//			break;
//	}
//	i_countx++;
//	for(i_county=10;i_county>i_countx;i_county--)
//		i_a[i_county]=i_a[i_county-1];
//	i_a[i_countx]=i_in;
//	for(i_countx=0;i_countx<11;i_countx++)
//		cout << i_a[i_countx] << ' ';
//	cout << endl;
//	system("pause");
//	return 0;
//}