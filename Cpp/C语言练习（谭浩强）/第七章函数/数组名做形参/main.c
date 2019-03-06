#include <stdio.h>
float average(float a[10]);
void main()
{
	int n;
	float a[10],t;
	printf("Please input 10 scores:");
	for(n=0;n<10;n++)
		scanf("%f",&a[n]);
	t=average(a);
	printf("The average score is:%-7.2f",t);
}

float average(float c[10])
{
	float m=0;
	int i;
	for(i=0;i<10;i++)
		m=m+c[i];
	m=m/10;
	return m;
}
