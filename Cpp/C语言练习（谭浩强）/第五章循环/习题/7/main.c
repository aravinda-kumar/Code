#include <stdio.h>
void main()
{
	int j;
	int m,n,t;
	float sum1=0,sum2=0,sum3=0,sum=0,k;
	for(m=1;m<=100;m++)
		sum=sum+m;
	for(n=1;n<=50;n++)
		{
			j=n*n;
			sum=sum+j;
		}
	for(t=1;t<=10;t++)
	{
		k=1.0/t;
		sum=sum+k;
	}
	printf("The summary is:%-10.2f",sum);
}
