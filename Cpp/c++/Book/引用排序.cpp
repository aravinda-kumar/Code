//#include <iostream>
//using namespace std;
//
//void sorted(int &ir_a, int &ir_b, int &ir_c);
//void change_2(int &ir_a, int &ir_b);
//
//int main()
//{
//	int i_a,i_b,i_c;
//	int &ir_a=i_a,&ir_b=i_b,&ir_c=i_c;
//	cout << "3 numbers:" << endl;
//	cin >> i_a >>i_b >> i_c;
//	
//	sorted(i_a, i_b, i_c);
//
//	cout << "sorted:" << endl;
//	cout << i_a << ' ' << i_b << ' ' << i_c << endl;
//	cout << ir_a << ' ' << ir_b << ' ' << ir_c << endl;
//
//	system("pause");
//	return 0;
//}
//
//void sorted(int &ir_a, int &ir_b, int &ir_c)
//{
//	if(ir_a>ir_b) change_2(ir_a, ir_b);
//	if(ir_a>ir_c) change_2(ir_a, ir_c);
//	if(ir_b>ir_c) change_2(ir_b, ir_c);
//}
//
//void change_2(int &ir_a, int &ir_b)
//{
//	int i_tmp;
//	i_tmp = ir_a;
//	ir_a = ir_b;
//	ir_b = i_tmp;
//}