#include <stdio.h>
int length(char *p);
void main()
{
	char ch[30];
	printf("Please input s string:");
	gets(ch);
	int n;
	n=length(ch);
	printf("The string's length is :%d",n);
}
int length(char *p)
{
	int i,n=0;
	for(i=0;*(p+i)!='\0';i++)
	{
		if(*(p+i)!='\0')
		n++;
	}
	return n;
}

