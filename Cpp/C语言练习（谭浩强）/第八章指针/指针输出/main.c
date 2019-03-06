#include <stdio.h>
void main()
{
	int a[10];
	int *p;
	int i;
	for(i=0;i<10;i++)
		scanf("%d",a+i);
//	for(p=a;p<(a+10);p++)
//		printf("%d\t",*p);
	for(i=0;i<10;i++)
		printf("%d\t",*(a+i));	
} 
