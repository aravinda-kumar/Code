//#include <iostream>
//using namespace std;
//
//template<typename T>
//void change_3(T *ip_a, T *ip_b, T*ip_c)
//{
//	if(*ip_a > *ip_b) change_2(ip_a, ip_b);
//	if(*ip_a > *ip_c) change_2(ip_a, ip_c);
//	if(*ip_b > *ip_c) change_2(ip_b, ip_c);
//}
//
//template<typename T>
//void change_2(T *ip_a, T *ip_b)
//{
//	T i_tmp;
//	i_tmp = *ip_a;
//	*ip_a = *ip_b;
//	*ip_b = i_tmp;
//}
//
//int main()
//{
//	double i_a,i_b,i_c;
//	double *ip_a, *ip_b, *ip_c;
//	
//	ip_a = &i_a;
//	ip_b = &i_b;
//	ip_c = &i_c;
//
//	cout << "input three numbers:" << endl;
//	cin >> i_a >> i_b >> i_c;
//	
//	change_3(ip_a, ip_b, ip_c);
//
//	cout << "sorted:" << endl;
//	cout << i_a << ' ' << i_b << ' ' << i_c << endl;
//
//	system("pause");
//	return 0;
//}