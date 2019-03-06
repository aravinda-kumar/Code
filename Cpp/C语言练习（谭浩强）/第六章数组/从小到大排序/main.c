#include <stdio.h>
#include <stdlib.h>
void main()
{
	int a[10];
	int i,j,k;
	printf("请输入十个数：");
	for(i=0;i<10;i++)
		scanf("%d",&a[i]);
	for(i=0;i<9;i++)
	{
		for(j=0;j<9;j++)
		{
			if(a[j]>a[j+1])
			{
				k=a[j];
				a[j]=a[j+1];
				a[j+1]=k;
			}
		}
	}
	for(i=0;i<10;i++)
		printf("%d\t",a[i]);
}
