#include <stdio.h>
void paixu(int *p1,int *p2,int *p3);
void main()
{
	int a,b,c;
	int *p1,*p2,*p3;
	p1=&a;p2=&b,p3=&c;
	printf("Please input three integer numbers:");
	scanf("%d%d%d",p1,p2,p3);
	paixu(p1,p2,p3);
	printf("Thw sorted three integer numbers:");
	printf("%d\t%d\t%d\t",a,b,c);
}
void paixu(int *p1,int *p2,int *p3)
{
	int temp;
	if(*p1>*p2)
	{
		temp=*p1;*p1=*p2;*p2=temp;
	}
	if(*p1>*p3)
	{
		temp=*p1;*p1=*p3;*p3=temp;
	}
	if(*p2>*p3)
	{
		temp=*p2;*p2=*p3;*p3=temp;
	}
}
