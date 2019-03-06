#include <stdio.h>
#include <string.h>
void copy(int x,int y,char a[],char b[])
{
	int i,j=0;
	for(i=x;i<=x+y;i++)
		a[i]=b[j++];
}
void main()
{
	char ch1[30];
	char ch2[20];
	gets(ch1);
	gets(ch2);
	int i,k;
	i=strlen(ch1);
	k=strlen(ch2);
	copy(i,k,ch1,ch2);
	printf("%s",ch1);
}
