#include <stdio.h>
int max2(int x,int y);
int max4(int a,int b,int ,int d);
void main()
{
	int n1,n2,n3,n4,max;
	printf("Please input four numbers:");
	scanf("%d %d %d %d",&n1,&n2,&n3,&n4);
	max=max4(n1,n2,n3,n4);
	printf("The biggest number is:%d",max);
}

int max4(int a,int b,int c,int d)
{
	int m;
	m=max2(a,b);
	m=max2(m,c);
	m=max2(m,d);
	return m;
}

int max2(int x,int y)
{
	int r;
	r=x>y?x:y;
	return r;
}
