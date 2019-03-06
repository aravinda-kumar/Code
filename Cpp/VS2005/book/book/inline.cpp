//#include<iostream>
//using namespace std;
//
//inline int max_3(int i_a1, int i_a2, int i_a3);
//int max_2(int i_a1, int i_a2);
//
//int main()
//{
//	int i_a1, i_a2, i_a3;
//	cin >> i_a1 >> i_a2 >> i_a3;
//	int i_max;
//	i_max = max_3(i_a1, i_a2, i_a3);
//	cout << i_max << endl;
//
//	system("pause");
//	return 0;
//}
//
//inline int max_3(int i_a1, int i_a2, int i_a3)
//{
//	i_a1 = max_2(i_a1, i_a2);
//	i_a1 = max_2(i_a1, i_a3);
//	return i_a1;
//}
//
//int max_2(int i_a1, int i_a2)
//{
//	return i_a1>i_a2? i_a1:i_a2;
//}