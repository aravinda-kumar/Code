#include <stdio.h>
int mi(int n)
{
	extern int A;
	int i,y=1;
	for(i=0;i<n;i++)
		y=y*A;
	return y;
}
int A;
void main()
{
	int i,j,m;
	printf("Please input THE num A&m:");
	scanf("%d %d",&A,&m);
	j=A*m;
	printf("%d*%d=%d\n",A,m,j);
	i=mi(m);
	printf("%d^%d=%d",A,m,i);
}
