#include <stdio.h>
int jiec(int x);
void main()
{
	int i,j;
	for(i=1;i<=5;i++)
	{
		j=jiec(i);
		printf("%d�Ľ׳��ǣ�%d\n",i,j);
	}
}
int jiec(int x)
{
	static int b=1;
	b=x*b;
	return b;
}
