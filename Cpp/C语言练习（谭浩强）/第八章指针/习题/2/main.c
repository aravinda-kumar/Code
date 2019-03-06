#include <stdio.h>
#include <string.h>
void paixu(char *p1,char *p2,char *p3);
void main()
{
	char a1[30];
	char a2[30];
	char a3[30];
	printf("Please input 3 strings:");
	gets(a1);
	gets(a2);
	gets(a3);
	char *p1,*p2,*p3;
	p1=a1;p2=a2;p3=a3;
	paixu(p1,p2,p3);
	printf("The sorted strings are:");
}
void paixu(char *p1,char *p2,char *p3)
{
	char *p;
	if(strcmp(p1,p2)>0)
	{
		p=p1;p1=p2;p2=p;
	}
	if(strcmp(p1,p3)>0)
	{
		p=p1;p1=p3;p3=p;
	}
	if(strcmp(p2,p3)>0)
	{
		p=p2;p2=p3;p3=p;
	}	
	printf("%s\n%s\n%s\n",p1,p2,p3);
}
