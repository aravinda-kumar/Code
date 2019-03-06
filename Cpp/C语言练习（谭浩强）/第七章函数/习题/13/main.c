#include <stdio.h>
float le(int n,int a)
{
	float i;
	if(n==0)
		i=1;
	else
	{
		if(n==1)	i=a;
		else
		{
			if(n>=1)
				i=((2*n-1)*a-le(n-1,a)-(n-1)*le(n-2,a))/n;
		}
	}
	return i;
}
void main()
{
	int n,x;
	printf("Please input 2 numbers N&X:");
	scanf("%d %d",&n,&x);
	printf("%-7.2f",le(n,x));
}
