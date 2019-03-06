#include <stdio.h>
#include <stdlib.h>
void main()
{
	float f1=1,f2=2,f3,i;
	float sum;
	sum=f2/f1;
	for(i=2;i<=20;i++)
	{
		f3=f1+f2;
		sum=sum+f3/f2;
		f1=f2;
		f2=f3;
	}
	printf("%-7.2f",sum);
}
