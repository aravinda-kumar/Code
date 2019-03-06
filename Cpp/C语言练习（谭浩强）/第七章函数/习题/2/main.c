#include <stdio.h>
#include <math.h>
float x1,x2;
void outcomeb()
{
	printf("NO COMEOUT!");
}

float outcomez(float a,float b)
{
	float x;
	x=-b/(2*a);
	return x;
}

void outcomea(float a,float b,float c)
{
	float q,m,n;
	q=sqrt(c);
	m=-b/(2*a);
	n=q/(2*a);
	x1=m+n;
	x2=m-n;
}

void main()
{
		float a,b,c;
		float s;
start:	printf("The element 'A' cannot be zero!\n");
		printf("Please input THREE elements(a&b&c):");
		scanf("%f%f%f",&a,&b,&c);
		if(a==0)
		{
			printf("输入错误，请重新输入！\n");
			goto start;
		}
		else
		{
			s=b*b-4*a*c;
			if(s>0)
			{
				outcomea(a,b,s);
				printf("两个根分别是%-7.2f和%-7.2f。",x1,x2);				
			}
			else
			{
				if(s==0)	printf("The outcome is:%-7.2f",outcomez(a,b));					
				else	if(s<0)		outcomeb();
			}
		}
}
