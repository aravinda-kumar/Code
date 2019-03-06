#include "stdio.h"
int main()
{
	double a,b,s,t,n;
	s=0;
	a=1;
	b=2;
	n=20;
	while(n>0)
	{
		s=s+b/a;
		t=a+b;
		a=b;
		b=t;
		n--;
	}
	printf("%.3f\n",s);
	return 0;
}
