#include <stdio.h>
void main()
{
	int a[3][3]={1,2,3,4,5,6,7,8,9};
	int sum=0,i;
	for(i=0;i<3;i++)
	{
		if(i==1)
		{
			sum=sum+a[i][i];
		}
		else
		{
			sum=sum+a[i][i]+a[i][2-1];
		}
	}
	printf("The summary is:%d",sum);
}
