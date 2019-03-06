#include "stdio.h"
int main()
{
	int n,s,t,i;
	n=20;
	s=0;
	t=1;
	i=1;
	while(i<=n)
	{
		t=i*t;
		s=s+t;
		i++;
	}
	printf("%d\n",s);
	return 0;
}
