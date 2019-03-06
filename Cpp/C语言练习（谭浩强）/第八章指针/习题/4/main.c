#include <stdio.h>
void change(int *p,int n,int m);
void main()
{
	int a[10]={1,2,3,4,5,6,7,8,9,10};
	int n;
	printf("Please input three integer numbers:");
	scanf("%d",&n);
	change(a,n,10);
}
void change(int *p,int n,int m)
{
	int *pt;
	int i,j;
	pt=p;
	printf("The sorted arrary is:\n");
	for(i=0;i<n;i++)
		printf("%d\t",*(p+m-n+i));
	for(i=0;i<m-n;i++)
		printf("%d\t",*(p+i));
}
