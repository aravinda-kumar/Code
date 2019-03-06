#include <stdio.h>
void exchange(int *p1,int *p2);
void main()
{
	int a,b;
	int *pa,*pb;
	printf("Please input two integer numbers:");
	scanf("%d %d",&a,&b);
	pa=&a;pb=&b;
		exchange(pa,pb);
	printf("Max=%d,Min=%d",*pa,*pb);	
}
void exchange(int *p1,int *p2)
{
	int temp;
	if(*p1<*p2)
	{
		temp=*p1;*p1=*p2;*p2=temp;
	}
}
