#include <stdio.h>
void inv(int x,int *p)
{
	int temp,m,n;
	int t;
	n=x/2;
	for(m=0;m<n;m++,p++)
	{
		t=2*(n-m)-1;
		temp=*p;*p=*(p+t);*(p+t)=temp;
	}
}
void main()
{
	int a[10]={3,7,9,11,0,6,7,5,4,2};
	int i;
	printf("The original array is:\n");
	for(i=0;i<10;i++)
		printf("%d\t",a[i]);
	printf("\n");
	inv(10,a);
	printf("The array has been inverted:\n");
	for(i=0;i<10;i++)
		printf("%d\t",a[i]);
}
