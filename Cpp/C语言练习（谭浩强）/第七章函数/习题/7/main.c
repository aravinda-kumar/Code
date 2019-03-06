#include <stdio.h>
#include <string.h>
void move(int x,char a[],char b[])
{
	int i,j=0;
	for(i=0;i<x;i++)
	{
		if(a[i]=='a'||a[i]=='e'||a[i]=='i'||a[i]=='o'||a[i]=='u'||a[i]=='A'||a[i]=='E'||a[i]=='I'||a[i]=='O'||a[i]=='U')
		{
			b[j++]=a[i];
		}
	}
	b[j]='\0';
}
void main()
{
	char ch1[20];
	char ch2[20];
	printf("Please input a string:");
	gets(ch1);
	int i;
	i=strlen(ch1);
	move(i,ch1,ch2);
	printf("%s",ch2);
}
