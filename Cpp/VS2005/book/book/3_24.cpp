//#include <iostream>
//using namespace std;
//
//int main()
//{
//	int i_count, j_count;
//	int tmp = 1;
//	const int limit = 17;
//	for (i_count=0;i_count<limit;i_count++)
//	{
//		if (i_count<=limit/2)
//		{
//			for (j_count=0;j_count<2*i_count+1;j_count++)
//				cout << "* ";
//		}
//		else
//		{
//			for (j_count=0;j_count<2*(i_count-2*tmp)+1;j_count++)
//				cout << "* ";
//			tmp++;
//		}
//		cout << endl;
//	}
//
//	system("pause");
//	return 0;
//}