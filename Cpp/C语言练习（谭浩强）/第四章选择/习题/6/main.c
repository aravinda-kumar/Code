#include <stdio.h>
#include <stdlib.h>
void main()
{
	float x,y;
	scanf("%f",&x);
	if(x<1)
	{
		y=x;
	}
	else
	{
		if(x<10)
		{
			y=2*x-1;
		}
		else
		{
			y=3*x-11;
		}
	}
	printf("%-5.2f",y);
}
