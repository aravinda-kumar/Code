#include <stdio.h>
void main()
{
	int a,i,sum;
	for(a=1;a<=1000;a++)
	{	sum=0;
		for(i=1;i<a;i++)
		{
			if((a%i)==0)
				sum=sum+i;
		}
		if(sum==a)
			{
				printf("%d\t its factors are ",a);
				for(i=1;i<a;i++)
					{
						if((a%i)==0)
						printf("%d,",i);			
					}
				printf("\n");
			}
	}
}
