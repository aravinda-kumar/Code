#include <stdio.h>
#include <math.h> 
void main()
{
	float a,b,c,p,q,disc,x1,x2;
	scanf("%f%f%f",&a,&b,&c);
	if(a==0)
	{
		printf("这不是一个二元一次方程！");
	} 
	else 
	{
		disc=b*b-4*a*c;
		if(disc<0)
		{
			printf("方程没有实根！");
		}
		else
		{
			p=-b/(2.0*a);
			q=sqrt(disc)/(2.0*a);
			x1=p+q;
			x2=p-q;
			if(disc>0)
				{
					printf("x1=%-7.2f   x2=%-7.2f",x1,x2);
				}
			else
				{
					printf("x1=x2=%-7.2f",x2);
				}
				
		}
	}
}			



