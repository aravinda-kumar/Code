#include <stdio.h>
void main()
{
	int i,j,k;
	int a;
	printf("三位数中的水仙花数有："); 
	for(a=100;a<1000;a++)
	{
		i=a/100;
		j=a%100/10;
		k=a%10;
		if((i*i*i+j*j*j+k*k*k)==a)
			printf("%d\t",a);
	}
}
