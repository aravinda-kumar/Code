#include <stdio.h>
#include <string.h>
void sort(char *p[],int n);
void print(char *p[],int n);
void main()
{
	char * name[5]={"Follow me","BASIC","Great Wall","FORTRAN","Computer desingn"};
	sort(name,5);
	print(name,5);	
}
void sort(char *p[],int n)
{
	int i,k;
	char *temp;
	for(i=0;i<n-1;i++)
	{
		for(k=0;k<n-1-i;k++)
		{
			if(strcmp(p[k],p[k+1])>0)
			{
				temp=p[k];p[k]=p[k+1];p[k+1]=temp;
			}
		}	
	}
}
//void print(char *p[],int n)
//{
//	int i;
//	for(i=0;i<n;i++)
//		printf("%s\n",p[i]);
//}
void print(char *p[],int n)
{
	int i,j,k;
	for(i=0;i<n;i++)
	{
		j=strlen(p[i]);
		for(k=0;k<j;k++)
		{
			printf("%c",*(p[i]+k));
		}
		printf("\n");
	}
}
