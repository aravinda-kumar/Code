#include <stdio.h>
#include <math.h>
void main()
{
	int a=3;
	float x1=2,x2;
	float t=1;
	while(fabs(t)>1e-6)
	{
		x2=(x1+a/x1)/2;
		t=x2-x1;
		x1=x2;
	}	
	printf("%-15.10f",x1);
} 
