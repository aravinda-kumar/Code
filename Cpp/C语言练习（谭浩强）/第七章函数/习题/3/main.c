#include <stdio.h>
int fun(int a)
{
	int i,j;
	for (i=2; i<a; i++)
	5
		if(a%i==0)
			break;
	
	if(i==a)	j=1;
		else		j=0;	 
	return j; 
}
void main ()
{
	int a;
	int i;
	printf("Please input a number:");
	scanf("%d",&a);
	i=fun(a);
	if(i==1)
		printf("����һ������");
	else 
		if(i==0)	
			printf("�ⲻ��һ������");	
}
