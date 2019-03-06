#include <stdio.h>
#include <stdlib.h>
 
void main()
{
	float a,b,c,t;
	printf("please input three numbers:");
	scanf("%f%f%f",&a,&b,&c);
	if(a<b)
	{
		t=a;a=b;b=t;
	}
	if(a<c)
	{
		t=a;a=c;c=t;
	}
	if(b<c)
	{
		t=b;b=c;c=t;
	}
	printf("The biggest number is:%-7.2f",a);
}
