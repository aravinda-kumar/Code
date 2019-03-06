#include <stdio.h>
#include <string.h>
void paixu(char *p[],int n);
void main()
{
	char *a[]={"japan","chinese","american"};
	int i;
	paixu(a,3);
	for(i=0;i<3;i++)
		printf("%s\n",a[i]);
}
void paixu(char *p[],int n)
{
	int *temp;
		if(strcmp(p[0],p[1])>0)
		{	
			temp=p[0];p[0]=p[1];p[1]=temp;
		}
		if(strcmp(p[1],p[2])>0)
		{	
			temp=p[1];p[1]=p[2];p[2]=temp;
		}
		if(strcmp(p[0],p[2])>0)
		{	
			temp=p[0];p[0]=p[2];p[2]=temp;
		}
}
