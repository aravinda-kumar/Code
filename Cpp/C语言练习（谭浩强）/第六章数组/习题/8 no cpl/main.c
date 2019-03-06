#include <stdio.h>
void main()
{
	int a[3][3]={1,2,16,10,1,11,2,2,15};
	int i,j,k,t,p,h=a[0][0],l;
	for(i=0;i<1;i++)
	{
		for(j=0;j<3;j++)
		{
			if(h<a[i][j])
			{
				h=a[i][j];
				k=j;
			}
		}
		l=a[0][k];
		for(t=0;t<3;t++)
		{
			if(l>=a[t][2])
			{
				l=a[t][k];
				p=t;
			}
		}
		if(h==l) 
			printf("%d\t",h);
		else
			printf("no!");
	}
}
