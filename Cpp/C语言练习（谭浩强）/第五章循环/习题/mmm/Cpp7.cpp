#include "stdio.h"
int main()
{
	int k;
	float s1,s2,s3,s;
	k=1;s1=0;s2=0;s3=0;
	while(k<=100)
	{
		s1=s1+k;
		k++;
	}
	k=1;
	while(k<=50)
	{
		s2=s2+k*k;
		k++;
	}
	k=1;
	while(k<=10)
	{
		s3=s3+1.0/k;
		k++;
	}
	s=s1+s2+s3;
	printf("%.3f\n",s);
	return 0;
}
