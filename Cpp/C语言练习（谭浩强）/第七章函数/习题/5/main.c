#include <stdio.h>
#include <string.h>
void daoxu(int x,char ch[])
{
	int i;
	char c;
	for(i=0;i<x/2;i++)
	{
		c=ch[i];ch[i]=ch[x-i-1];ch[x-i-1]=c;
	}
}
void main()
{
	char ch[30];
	printf("Pleae input a string:");
	gets(ch);
	int i,j;
	i=strlen(ch);
	daoxu(i,ch);
	for(j=0;j<i;j++)
		printf("%c",ch[j]);
}
