#include <stdio.h>
#include <string.h>
void main()
{
	char a[3][20];
	char str[20];
	int i;
//	for(i=0;i<3;i++)
	{
		gets(a[0]);
//		gets(a[1]);
//		gets(a[2]);
	}
	if(strcmp(a[0],a[1])<0)
	{
		strcpy(str,a[1]);
	}
	else
	{
		strcpy(str,a[0]);
	}
	if(strcmp(str,a[2])<0)
		strcpy(str,a[2]);
	puts(str);
}
