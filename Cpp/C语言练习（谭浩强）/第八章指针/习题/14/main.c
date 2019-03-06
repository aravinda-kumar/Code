#include <stdio.h>
void daoxu(int *p,int n);
void main()
{
	int a[10];
	int i;
	printf("Please input 10 integer numbers:");
	for(i=0;i<10;i++)
		scanf("%d",&a[i]);
	daoxu(a,10);
	printf("The sorted 10 integer numbers are:");
	for(i=0;i<10;i++)
		printf("%d\t",a[i]);
}
void daoxu(int *p,int n)
{
	int i,temp;
	for(i=0;i<n/2-1;i++)
	{
		temp=*(p+i);*(p+i)=*(p+n-i-1);*(p+n-i-1)=temp;
	}
}
