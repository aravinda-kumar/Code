//#include <iostream>
//using namespace std;
//
//int max_1(int i_a1, int i_a2);
//int min_1(int i_a1, int i_a2);
//
//int main()
//{
//	int i_a1,i_a2;
//	cin >> i_a1 >> i_a2;
//	cout << "最大公约数："<< max_1(i_a1, i_a2) << endl;
//	cout << "最小公倍数："<< min_1(i_a1, i_a2) << endl;
//	system("pause");
//	return 0;
//}
//
//int max_1(int i_a1, int i_a2)
//{
//	int i_tmp;
//	i_tmp = i_a1<i_a2? i_a1:i_a2;
//	for (;i_tmp>0;i_tmp--)
//	{
//		if(i_a1%i_tmp==0 && i_a2%i_tmp==0)
//		{
//			break;
//		}
//	}
//	return i_tmp;
//}
//int min_1(int i_a1, int i_a2)
//{
//	int i_tmp;
//	i_tmp = i_a1>i_a2? i_a1:i_a2;
//	for (;;i_tmp++)
//	{
//		if(i_tmp%i_a1==0 && i_tmp%i_a2==0)
//		{
//			break;
//		}
//	}
//	return i_tmp;
//}