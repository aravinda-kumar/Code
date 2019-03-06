#include <stdio.h>
#include <string.h>
void main()
{
	int i,num=0;
	char a[30];
	gets(a);
	for(i=0;a[i]!='\0';i++)
	{
		if((a[i]==32&&a[i+1]!=32)||a[i+1]=='\0')
		{
			num++;
		}
	}
	printf("%d",num);
}
