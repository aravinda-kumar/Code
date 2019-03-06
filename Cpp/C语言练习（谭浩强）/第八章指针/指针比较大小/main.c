#include <stdio.h>
void main()
{
	int a,b;
	int *p1,*p2,*p;
	printf("Please enter two integer numbers:");
	scanf("%d %d",&a,&b);
	p1=&a;p2=&b;
	if(a<b)
	{
		p=p1;p1=p2;p2=p;
	}
	printf("a=%d,b=%d\n",a,b);
	printf("Max=%d,Min=%d",*p1,*p2);
}
