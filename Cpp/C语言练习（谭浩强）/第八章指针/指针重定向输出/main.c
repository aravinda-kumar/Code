#include <stdio.h>
void main()
{
	int a[10];
	int *p,i;
	p=a;
	for(i=0;i<10;i++)
		scanf("%d",p++);
	p=a;
	for(i=0;i<10;i++,p++)
		printf("%d\t",*p);
} 
