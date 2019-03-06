#include <stdio.h>
int age(int n)
{
	int m;
	if(n==1)
		m=10;
	else
		m=age(n-1)+2;
	return m;
}
void main()
{
	int n,a;
	printf("Please input the number of student:");
	scanf("%d",&n);
	a=age(n);
	printf("The age of the NO.%d student is:%d",n,a);
}
