#include <stdio.h>
float average(int x,float a[ ]);
float Max,Min;
void main()
{
	float a[10]={1,2,3,4,5,6,7,8,9,10};
	float ave;
	ave=average(10,a);
	printf("The larggest number is:%-7.2f\n",Max);
	printf("The smallest number is:%-7.2f\n",Min);
	printf("The average number is:%-7.2f\n",ave);
}

float average(int x,float a[ ])
{
	int i;
	float ave = 0;
	Max=a[0];
	Min=a[0];
	for(i=0;i<x;i++)
	{
		if(Max<a[i])	    Max=a[i];
		if(Min>a[i])   	Min=a[i];
		ave = ave +a[i];
	}
	ave=ave/i;
	return ave;
}
