#include "stdio.h"
int main()
{
	int m,n,t,q;
	scanf("%d,%d",&m,&n);
	if(m>n)
	{
		t=m;
		m=n;
		n=t;
	}
	q=m;
	t=n%m;
	while(t!=0)
	{
		m=t;
		n=m;
		t=n%m;
	}
	printf("最大公约数为%d\n",m);
	q*=m;
	printf("最小公倍数为%d\n",q);
	return 0;
}

	
