#include <stdio.h>
void paixu(int *p1[],int n);
void main()
{
	int a[10];
	int i;
	int *p[10];
	printf("Please input 10 integer numbers:");
	for(i=0;i<10;i++)
		scanf("%d",&a[i]);
	for(i=0;i<10;i++)
		p[i]=&a[i];
	int **p1;
	p1=p;
	paixu(p1,10);
	printf("The sorted numbers are:\n");
	for(i=0;i<10;i++)
		printf("%d\t",*(*(p1+i)));
}
void paixu(int *p1[],int n)
{
	int i,j;
	int *temp;
	for(i=0;i<n-1;i++)
	{
		for(j=0;j<n-1-i;j++)
		{
			if(*(*(p1+j))<*(*(p1+j+1)))
			{
				temp=*(p1+j);*(p1+j)=*(p1+j+1);*(p1+j+1)=temp;
			}
		}
	}
}
