#include "stdio.h"
#include "math.h"
int main()
{
	int n,a,s,t,q;
	scanf("%d,%d",&a,&n);
	s=0;
	t=a;
	q=n;
	while(n>0)
	{
		s=s+t;
		t=t+a*pow(10,q-n+1);
		n--;
	}
	printf("%d\n",s);
	return 0;
}


