#include <stdio.h>
#include <stdlib.h>
void main()
{
	int n,i;
	printf("Please input a number bigger than 3:");
	scanf("%d",&n);
	for(i=2;i<=n-1;i++)
	{
		if(n%i==0)
			break;
	}
	printf("%d\n",i);
	if(i<n)
		printf("这不是一个素数。");
	if(i==n)
		printf("这是一个素数。");
}

