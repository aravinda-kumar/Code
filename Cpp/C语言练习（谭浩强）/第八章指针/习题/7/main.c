#include <stdio.h>
void cp(char *p1,char *p2,int n);
void main()
{
	char ch[17];
	char st[17];
	int m;
	printf("Please input a string :");
	gets(ch);
	printf("Please input a integer number:");
	scanf("%d",&m);
	cp(ch,st,m);	
}
void cp(char *p1,char *p2,int n)
{
	printf("The original string is:%s\n",p1);
	int i,j,k;
	for(i=0;*(p1+n-1+i)!='\0';i++)
	{
		*(p2+i)=*(p1+n-1+i);
	}
	*(p2+i)='\0';
	printf("The copied string is:%s\n",p2);
}
