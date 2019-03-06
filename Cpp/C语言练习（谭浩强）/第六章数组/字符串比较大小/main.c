#include <stdio.h>
#include <string.h>
void main()
{
	char str1[30],str2[30],str3[30];
	gets(str1);
	gets(str2);
	gets(str3);
	if(strcmp(str1,str2)<0)
		strcpy(str1,str2);
	if(strcmp(str1,str3)<0)
		strcpy(str1,str3);	
	printf("%s",str1);
}
