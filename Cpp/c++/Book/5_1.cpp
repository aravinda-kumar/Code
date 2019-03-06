//#include<iostream>
//using namespace std;
//
//bool is_prime(int i_count);
//
//int main()
//{
//	int i_count;
//	for (i_count=0;i_count<100;i_count++)
//	{
//		if (i_count==0 || i_count==1)
//			continue;
//		if(is_prime(i_count))
//			cout << i_count << ' ';
//	}
//	cout << endl;
//	
//	system("pause");
//	return 0;
//}
//
//bool is_prime(int i_count)
//{
//	int i_tmp;
//	if(i_count==2)
//		return true;
//	for(i_tmp=2;i_tmp<i_count-1;i_tmp++)
//		if(i_count%i_tmp==0)
//			return false;
//	if(i_tmp == i_count)
//		return true;
//}