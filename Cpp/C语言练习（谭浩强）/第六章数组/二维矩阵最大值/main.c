#include <stdio.h>
#include <stdlib.h>
void main()
{
	int a[3][4]={1,2,3,4,9,8,7,6,-10,10,-5,2};
	int max,i,j,hang,lie;
	max=a[0][0];
	for(i=0;i<3;i++)
	{
		for(j=0;j<4;j++)
			{
				if(a[i][j]>max)
				{
					max=a[i][j];
					hang=i;
					lie=j;
				}
			}	
	}	
	for(i=0;i<3;i++)
	{
		for(j=0;j<4;j++)
			{
				if(a[i][j]==max)
				{
					break;
				}
			}	
	}
	printf("矩阵中最大的值是=%d\n",max);
	printf("它位于第%d行,第%d列\n",i,++j);
	printf("它位于第%d行,第%d列",++hang,++lie);
}
