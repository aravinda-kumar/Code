#include <stdio.h>
void main()
{
	int i,mul,k,sum=0;
	for(k=1;k<=20;k++)
	{	
		mul=1;
		for(i=1;i<=k;i++)
			{
				mul=mul*i;
			}
		sum=sum+mul;	
	}
	printf("The summary is:%d",sum);
}
