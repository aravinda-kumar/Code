#include <stdio.h>
void main()
{
	int i,j,k;
	for(i=1;i<=4;i++)
	{
		for(k=1;k<=4-i;k++)
			printf(" ");
		for(j=0;j<2*i-1;j++)
			printf("*");
		printf("\n");
	}
	for(i=3;i>=1;i--)
	{
		for(k=1;k<=4-i;k++)
			printf(" ");
		for(j=0;j<2*i-1;j++)
			printf("*");
		printf("\n");
	}
}
