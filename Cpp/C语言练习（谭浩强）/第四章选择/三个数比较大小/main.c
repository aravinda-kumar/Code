#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() 
{
	float a,b,c,t;
	scanf("%f%f%f",&a,&b,&c);
	if(a>=b) 
	{
		t=a; a=b; b=t;
	} 
	if(b>=c) 
	{
	t=c; c=b; b=t;
	} 
	if(a>=c) 
	{
		t=a; a=c; c=t;
	} 
	printf("%-7.2f\n%-7.2f\n%-7.2f",a,b,c);
}
