#include <stdio.h>
int max(int x,int y)
{
	return x>y?x:y;	
} 
void main()
{
	int a[10];
	int i,n=0,m;
	printf("Please input 10 numbers:");
	for(i=0;i<10;i++)
		scanf("%d",&a[i]);
	m=a[0];
	for(i=0;i<10;i++)
		{
			if(max(m,a[i])>m)
			{
				m=max(m,a[i]);
				n=i;
			}
		}
	printf("The largest number is:%d\n",m);
	printf("It is NO.%d",n+1);
}
