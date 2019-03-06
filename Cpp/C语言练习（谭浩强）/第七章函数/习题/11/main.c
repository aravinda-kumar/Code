#include <stdio.h>
void paixu(int x,int a[])
{
	int i,j,m;
	for(i=0;i<x-1;i++)
	{
		for(j=0;j<x-i-1;j++)
		{
			if(a[j]>a[j+1])
			{
				m=a[j];a[j]=a[j+1];a[j+1]=m;
			}
		}
	}
}
void main()
{
	int a[10];
	int i;
	printf("Please input 10 numbers:");
	for(i=0;i<10;i++)
		scanf("%d",&a[i]);
	paixu(10,a);
	for(i=0;i<10;i++)
		printf("%d\t",a[i]);
}
