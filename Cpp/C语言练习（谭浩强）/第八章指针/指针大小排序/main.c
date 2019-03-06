#include <stdio.h>
void paixu(int *p1,int n)
{
	int i,j,*x=p1,temp;
	for(i=0;i<n-1;i++)
	{
		x=p1;
		for(j=0;j<n-i-1;j++)
		{
			if(*x<*(x+1))
			{
				temp=*x;
				*x=*(x+1);
				*(x+1)=temp;
			}
			x++;
		}
	}
}
void main()
{
	int a[10]={12,34,5,689,-43,56,-21,0,24,65};
	int *p=a;
	int i;
	paixu(p,10);
	for(i=0;i<10;i++)
		printf("%d ",*p++); 
}
