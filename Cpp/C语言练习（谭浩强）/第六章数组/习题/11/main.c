#include <stdio.h>
void main()
{
	char a[5][9];
	int i,j,k,m;
	for(i=0;i<5;i++)
	{
		for(j=0;j<i;j++)
		{	a[i][j]=' ';}
		for(k=i;k<i+5;k++)
		{	a[i][k]='*';}
		for(m=i+5;m<9;m++)
		{	a[i][m]=' ';}
	}
	for(i=0;i<5;i++)
	{
		for(j=0;j<9;j++)
			printf("%c",a[i][j]);
		printf("\n");
	}
}
