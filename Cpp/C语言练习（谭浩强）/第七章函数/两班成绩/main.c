#include <stdio.h>
float average(int n,float a[]);
void main()
{
	float score1[5]={98.5,97,91.5,60,55};
	float score2[10]={67.5,89.5,99,69.5,77,89.5,76.5,54,60,99.5};
	float pj1,pj2;
	pj1=average(5,score1);
	pj2=average(10,score2);
	printf("The average of Class A is:%-7.2f\n",pj1);
	printf("The average of Class B is:%-7.2f\n",pj2);
}

float average(int n,float a[])
{
	int i;
	float m=0;
	for(i=0;i<n;i++)
		m=m+a[i];
	m=m/i;
	return m; 
} 
