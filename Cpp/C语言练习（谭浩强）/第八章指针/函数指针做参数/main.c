#include <stdio.h>
//int max(int a,int b);
//int min(int a,int b);
//int add(int a,int b);
int max(int,int);
int min(int,int);
int add(int,int);
int fun(int a,int b,int (*p)(int,int));
void main()
{
	int a=34,b=-21,n;
//	int (*p)(int,int);
	printf("Please choose 1,2 or 3:");
	scanf("%d",&n);
	if(n==1)
	{
//		p=max;
//		printf("The max result is:%d",fun(a,b,p));
		printf("The max result is:%d",fun(a,b,max));
	}
	if(n==2)
	{
//		p=min;
//		printf("The min result is:%d",fun(a,b,p));
		printf("The min result is:%d",fun(a,b,min));
	}
	if(n==3)
	{
//		p=add;
//		printf("The add result is:%d",fun(a,b,p));
		printf("The add result is:%d",fun(a,b,add));
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
int add(int a,int b)
{
	return a+b;
}
int fun(int a,int b,int (*p)(int,int))
{
	return (*p)(a,b);
}
