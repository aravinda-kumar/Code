#include <stdio.h>
void pingjun(int i,int a[]);
void main()
{
	int a[10];
	int i;
	printf("Please input 10 numbers:");
	for(i=0;i<10;i++)
		scanf("%d",&a[i]);
	pingjun(10,a);
	printf("The sorted array is:");
	for(i=0;i<10;i++)
		printf("%d\t",a[i]);	
}
void pingjun(int i,int a[])
{
	int m,n,t,p;
	int min;
	for(m=0;m<i;m++)
	{	
		t=m;
		min=a[m];
		for(n=m;n<i;n++)
			if(min>a[n])
			{
				min=a[n];
				t=n;
			}
		p=a[t];a[t]=a[m];a[m]=p;
	}
}
