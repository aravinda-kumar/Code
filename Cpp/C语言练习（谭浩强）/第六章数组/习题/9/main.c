#include <stdio.h>
void main()
{
	int a[15]={15,14,13,12,11,10,9,8,7,6,5,4,3,2,1};
	int i,s,m,t;
	printf("Please input a number:");
	scanf("%d",&s);
	for(i=0;i<15;i++)
	{
		if(s==a[i])
		{
			printf("%d\t",i+1);
			break;
		}
	}
	if(i==15)
	{
		printf("no!");
	}

}
