#include<iostream>
using namespace std;

//将一个十进制数转换为16位的二进制数

//求取绝对值
unsigned __int64 ABS(__int64 a);
//求幂
__int64 POW(int a, unsigned int n);
//二进制置0
void ArrToZero(int a[], int length);
//二进制置1
void ArrToOne(int a[], int length);

int main()
{
	__int64 num = -1;
	int a[16];
	if (num >= 0)
	{
		ArrToZero(a, 16);
		for (int i = 0; i < 15; i++)
		{
			a[i] = num & 1;
			num >>= 1;
		}
	}
	else
	{
		ArrToOne(a, 16);
		cout << POW(2, 15) << endl;
		cout << ABS(num) << endl;
		num = POW(2, 15) - ABS(num);
		for (int i = 0; i < 15; i++)
		{
			a[i] = num & 1;
			num >>= 1;
		}
	}

	for (int i = 0; i < 16; i++)
	{
		cout << a[15 - i];
	}
	cout << endl;
	system("pause");
	return 0;
}

//求取绝对值
unsigned __int64 ABS(__int64 a)
{
	return a >= 0 ? a : -a;
}

//求幂
__int64 POW(int a, unsigned int n)
{
	__int64 tmp = 1;
	if (n == 0)
		return 1;
	while (n > 0)
	{
		tmp *= a;
		n--;
	}
	return tmp;
}

//二进制置0
void ArrToZero(int a[], int length)
{
	for (int i = 0; i < length; i++)
	{
		a[i] = 0;
	}
}
//二进制置1
void ArrToOne(int a[], int length)
{
	for (int i = 0; i < length; i++)
	{
		a[i] = 1;
	}
}