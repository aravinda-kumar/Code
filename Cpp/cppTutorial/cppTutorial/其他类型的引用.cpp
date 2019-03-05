//#include <iostream>
//using namespace std;
//
//struct Node
//{
//	int n;
//};
//
//int main()
//{
//	//常量的引用
//	const int &a = 12;
//
//	//数组的引用
//	int arr[12];
//	int(&r)[12] = arr;
//
//	r[2] = 14;
//	cout << arr[2] << endl;
//
//	int ar[2][3];
//	int(&rt)[2][3] = ar;
//	rt[1][2] = 15;
//	cout << ar[1][2] << endl;
//
//	Node node;
//	Node  &n = node;
//	n.n = 18;
//	cout << node.n << endl;
//
//	int num = 15;
//	int num1 = 18;
//	int *point = &num;
//	int *(&rp) = point;
//	
//
//	*rp = 20;
//	cout << num << endl;
//
//	rp = &num1;
//	cout << *point << endl;
//
//	system("pause");
//	return 0;
//}