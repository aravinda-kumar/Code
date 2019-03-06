//#include <iostream>
//using namespace std;
//
//void cmp(int* p1, int*p2);
//void change(int* p1,int* p2,int* p3)
//{
//	cmp(p1 ,p2);
//	cmp(p1 ,p3);
//	cmp(p2 ,p3);
//}
//
//void cmp(int* p1, int*p2)
//{
//	int tmp;
//	if(*p1 > *p2)
//	{
//		tmp = *p1; *p1 =*p2; *p2 = tmp;
//	}
//}
//
//int main()
//{
//	int a,b,c;
//	int* p1,* p2,* p3;
//	cout << "Please input 3 numbers:";
//	cin >> a >> b >> c ;
//	cout << "The origin number is:" << a << "  " << b << "  " << c << endl;
//	p1 = &a;
//	p2 = &b;
//	p3 = &c;
//	change(p1, p2, p3);
//	cout << "The outcome is:" << a << "  " << b << "  " << c << endl;
//	system("pause");
//	return 0;
//}