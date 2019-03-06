#include <stdio.h>
#include <string.h>
void paixu(char *p[],int n);
void main()
{
	char *a[3]={"china","japan","india"};
	char **p;
	int i;
	p=a;
	paixu(p,3);
	for(i=0;i<3;i++)
		printf("%s\n",a[i]);
}
void paixu(char *p[],int n)
{	
	int i,j;
	int *temp;
	for(i=0;i<n-1;i++)
	{
		for(j=0;j<n-1-i;j++)
		if(strcmp(*(p+j),*(p+j+1))>0)
		{
			temp=*(p+j);*(p+j)=*(p+j+1);*(p+j+1)=temp;
		}
	}
}
