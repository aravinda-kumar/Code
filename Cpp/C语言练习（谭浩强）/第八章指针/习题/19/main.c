#include <stdio.h>
#include <stdlib.h>
int *new(int n);
void main()
{
	int n;
	int *pt;
	printf("Please input a integer number:");
	scanf("%d",&n);
	pt=new(n);
	printf("%d\n",pt);
	free(pt);
}
int *new(int n)
{
	int *pt;
	pt=(int *)malloc(n*sizeof(int));
	return pt;
}
