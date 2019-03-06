#include <stdio.h>
#include <stdlib.h>
void main()
{
	int a[2][3]={1,2,3,4,5,6};
	int b[3][2];
	int i,j;
	for(i=0;i<2;i++)
	{
		for(j=0;j<3;j++)
			b[j][i]=a[i][j];
	}
	printf("矩阵a的值为：\n");
	for(i=0;i<2;i++)
	{
		for(j=0;j<3;j++)
			printf("%d\t",a[i][j]);
		printf("\n");
	}
	printf("矩阵b的值为：\n");
	for(i=0;i<3;i++)
	{
		for(j=0;j<2;j++)
			printf("%d\t",b[i][j]);
		printf("\n");
	}
}
