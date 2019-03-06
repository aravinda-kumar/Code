#include <stdio.h>
#include <stdlib.h>
void main()
{
	int i,n,j;
	for(n=100;n<=200;n++) 
	{
		for(i=2;i<=n-1;i++)
		{
			if(n%i==0)
				break;
		}
		if(i==n)
			printf("%d\t",n);
	}
}


