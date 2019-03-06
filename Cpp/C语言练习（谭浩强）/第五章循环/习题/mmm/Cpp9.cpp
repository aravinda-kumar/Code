#include "stdio.h"
int main()
{
	int i,s,j,q,t,p;

	for(i=2;i<=1000;i+=2)
	{
		s=0;
		for(j=1;j<i;j++)
		{
			q=i%j;
			if(q==0)
				s=s+j;

		}
			if(s==i)
			{
				printf("%-4dits factors are ",i);
				t=i;
				for(j=1;j<t;j++)
				{
					p=t%j;
					if(p==0)
						printf("%d,",j);
				}
				printf("\n");
			}
	}
	return 0;
}
	

