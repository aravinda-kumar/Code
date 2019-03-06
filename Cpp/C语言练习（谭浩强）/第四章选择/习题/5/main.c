#include <stdio.h>
#include <math.h>
void main()
{
		float a;
		int m;
start:  printf("Please input a number between 0 and 1000:");
		scanf("%f",&a);
		if (a>1000||a<0)
		{
			printf("ERROR! ");
		goto start;
		}
		else
		{
			m=sqrt(a);
			printf("%d",m);	
		} 
}
