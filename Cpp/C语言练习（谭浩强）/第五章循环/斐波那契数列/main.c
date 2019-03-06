#include <stdio.h>
#include <stdlib.h>
void main()
{
	int a1=1,a2=1,a3;
	int i;
	printf("%d\t%d\t",a1,a2);
//	for(i<=3;i<40;i++)
//	{
//		a3=a1+a2;
//		printf("%ld\t",a3);
//		a1=a2;
//		a2=a3;
//	}
//	printf("\n");
	for(i<=3;i<=20;i++)
	{
		a1=a1+a2;
		a2=a1+a2;
		printf("%ld\t%ld\t",a1,a2);
	}
}
