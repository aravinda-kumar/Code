#include <stdio.h>
void main()
{
	int a[10][10]={1};
	int i,j,k;
	for(i=1;i<10;i++)
	{
		a[i][0]=a[i][i]=1;
    	for(j=1;j<=i;j++)
			a[i][j]=a[i-1][j-1]+a[i-1][j];					
	}
	for(i=0;i<10;i++)
	{
		for(j=0;j<=i;j++)
			printf("%d\t",a[i][j]);
		printf("\n");
	}
}
