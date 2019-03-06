#include <stdio.h>
int max(int a,int b);
void main()
{
	int a,b,c;
	printf("Please input two integer numbers:");
	scanf("%d%d",&a,&b);
	int (*p)(int,int);
	p=max;
	c=(*p)(a,b);
	printf("The big number is:");
	printf("%d",c);
}
int max(int a,int b)
{
	int r;
	r=a>b?a:b;
	return r;
}
