#include <stdio.h>
void main()
{
	int i,j;
	for(i=1;i<=4;i++)
	{
		for(j=1;j<=5;j++)
		{
			if(i==3&&j==1)
	//			break;
	//			continue;
			printf("%d\t",i*j);
			if(j%5==0)
			{
				printf("\n");
			}

		}
	}
} 
