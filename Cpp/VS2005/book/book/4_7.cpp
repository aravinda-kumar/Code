//#include <iostream>
//using namespace std;
//
//bool prime(int i_a);
//
//int main()
//{
//	int i_count;
//	int i_tmp;
//	for (i_count=6;i_count<100;i_count++)
//	{
//		if(i_count%2==0)
//		{
//			for(i_tmp=2;i_tmp<i_count-1;i_tmp++)
//			{
//				if(prime(i_tmp) && prime(i_count-i_tmp) && (i_tmp != i_count-i_tmp))
//				{
//					cout << i_count << '=' << i_tmp << '+' << i_count-i_tmp << endl;
//					break;
//				}
//			}
//		}
//	}
//
//	system("pause");
//	return 0;
//}
//
//bool prime(int i_a)
//{
//	int i_tmp;
//	for (i_tmp=2;i_tmp<i_a;i_tmp++)
//	{
//		if(i_a%i_tmp==0)
//			return false;
//	}
//	return true;
//}