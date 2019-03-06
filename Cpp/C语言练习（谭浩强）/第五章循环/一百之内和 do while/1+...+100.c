#include<stdio.h>
void main()
{
	int i,sum;
	i=1;
	sum=0;
	do
	{
		sum=i+sum;
		++i;
	}
	while(i<=100);
	printf("The summary is:%d",sum);
}
