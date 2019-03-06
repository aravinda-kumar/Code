#include <stdio.h>
int max(int x,int y)
{
	int r;
	r=x>y?x:y;
	return r;
}
void main()
{
	int a,b,c;
	printf("Please input three numbers:");
	scanf("%d %d %d",&a,&b,&c);
	printf("The biggest number is:%d",max(c,max(a,b)));
} 
