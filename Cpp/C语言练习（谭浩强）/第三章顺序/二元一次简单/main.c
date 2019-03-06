#include <stdio.h>
#include <math.h>
void main()
{
	double a,b,c,p,q,x1,x2,t,m;
	scanf("%1f%1f%1f",&a,&b,&c);
	t=b*b-4*a*c;
	p=-b/(2.0*a);
	m=sqrt(t);
	q=m/(2.0*a);
	x1=p+q;
	x2=p-q;
	printf("x1=%7.2f\tx2=%7.2f/n",t,x2);	
}

