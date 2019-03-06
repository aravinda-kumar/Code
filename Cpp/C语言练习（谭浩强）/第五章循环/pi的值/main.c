#include <stdio.h>
void main()
{
	float i=1,sign=1;
	float s=1.0,j=1,pi=0,m;
	while(j>=1e-6)
	{
		j=s/i;
		pi=pi+j*sign;
		sign=sign*(-1);
		i=i+2;
	}
	pi=4*pi;
	printf("%10.8f",pi);
}
