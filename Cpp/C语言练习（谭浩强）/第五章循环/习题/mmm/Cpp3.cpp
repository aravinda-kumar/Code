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
	printf("���Լ��Ϊ%d\n",m);
	q*=m;
	printf("��С������Ϊ%d\n",q);
	return 0;
}

	
