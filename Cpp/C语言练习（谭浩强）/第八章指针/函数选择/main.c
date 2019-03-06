#include <stdio.h>
int max(int a,int b);
int min(int a,int b);
void main()
{
	int a,b,m,o;
	int (*p)(int,int);
	printf("Please input two integer numbers:");
	scanf("%d%d",&a,&b);
	printf("Please enter the modle number:");
	scanf("%d",&m);
	if(m==1)
	{
		p=max;
		o=(*p)(a,b);
		printf("The bigger number is:%d",o);
	}
	if(m==0)
	{
		p=min;
		o=(*p)(a,b);
		printf("The smaller number is:%d",o);		
	}
}
int max(int a,int b)
{
	return a>b?a:b;
}
int min(int a,int b)
{
	return a<b?a:b;
}
