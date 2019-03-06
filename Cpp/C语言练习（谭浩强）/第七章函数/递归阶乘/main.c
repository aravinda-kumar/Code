#include <stdio.h>
int jiec(int n)
{
	int r;
	if(n==1)
		r=1;
	else
		r=n*jiec(n-1);
	return r;
}
void main()
{
	int n,mul;
	printf("Please input number:");
	scanf("%d",&n);
	mul=jiec(n);
	printf("The outcome is:%d",mul);
}
