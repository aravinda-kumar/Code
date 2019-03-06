#include <stdio.h>
float pingjun(float (*p)[5],int n);
int* fail(float (*p)[5]);
int* good(float (*p)[5]);
void main()
{
	float a[4][5]={85,86,85,85,96,
				 45,84,59,60,86,
				 99,90,52,80,70,
				 60,70,80,90,66}; 
	float ave,sum=0;
	ave=pingjun(a,4);
	printf("The first class's average score is:%-7.2f\n",ave);
	int i;int *pt;int j;
	for(i=0;i<4;i++)
	{
		pt=fail(a+i);
		if(pt==a+i)
		{
			printf("No.%d student is failed.\n",i+1);
			printf("His(Her) score is:");
			for(j=0;j<5;j++)
			{
				printf("%-3.1f\t",*(*(a+i)+j));
				sum=sum+*(*(a+i)+j);
			}
			printf("\n");
			printf("His(Her) average score is:%-7.2f\n",sum/5);
		}	
	}
	for(i=0;i<4;i++)
	{
		pt=good(a+i);
		if(pt==a+i)
			printf("No.%d student is good.\n",i+1);
	}
}
float pingjun(float (*p)[5],int n)
{
	int i;
	float sum=0;
	for(i=0;i<n;i++)
		sum=sum+*(*(p+i));
	return sum/n;
}
int* fail(float (*p)[5])
{
	int i;
	int count=0;
	int *pt;
	pt=NULL;
	for(i=0;i<5;i++)
		if(*(*(p)+i)<60)
			count++;
	if(count>=2)	pt=p;
	return pt;
}
int* good(float (*p)[5])
{
	int i;
	int count=0;
	float sum=0,ave;
	int *pt;
	pt=NULL;
	for(i=0;i<5;i++)
	{
		if(*(*(p)+i)>=85)
			count++;
		sum=sum+*(*(p)+i);
	}
	ave=sum/5;
	if(count==5||ave>=90.00)	pt=p;
	return pt;	
}
