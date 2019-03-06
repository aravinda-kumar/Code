#include <stdio.h>
#include <stdlib.h>
void main()
{
	int a[20]={1,1};
	int i,j;
	for(i=2;i<20;i++)
		a[i]=a[i-1]+a[i-2];
	for(j=0;j<20;j++)
		printf("%d\t",a[j]);
}
