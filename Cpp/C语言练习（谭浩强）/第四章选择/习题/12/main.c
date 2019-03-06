#include <stdio.h>
#include <stdlib.h>
void main()
{
	float x1=2,x2=-2,y1=2,y2=-2;
	float x,y,d1,d2,d3,d4;
	printf("Please input your location[x,y]:");
	scanf("%f,%f",&x,&y);
	d1=(x-x1)*(x-x1)+(y-y1)*(y-y1);
	d2=(x-x1)*(x-x1)+(y-y2)*(y-y2);
	d3=(x-x2)*(x-x2)+(y-y1)*(y-y1);
	d4=(x-x2)*(x-x2)+(y-y2)*(y-y2);
	if(d1>1 && d2>1 && d3>1 && d4>1)
	{
		printf("The height is 0m");
	}
	else
	{
		printf("The height is 10m");
	}
} 
