#include <stdio.h>
void main()
{
	int a=2,i,t=0,n,sum=0;
	printf("Please input the positive integer:");
	scanf("%d",&n);
	for(i=1;i<=n;i++)
	{
		t=10*t+a;
		sum=sum+t;
	}
	printf("The summary is:%d",sum);
}
