#include <stdio.h>
#include <string.h>
void main()
{
	char a[20];
	int i,k,num=0;
	gets(a);
	k=strlen(a)+1;
	for(i=0;i<k;i++)
	{
//		if(a[i]==32||(a[i]=='\0'&&a[i-1]!=32))
		if((a[i]==32)&&(a[i+1]!=32))
			num++;
		if((a[i]=='\0'&&a[i-1]!=32))
		{
			num++;
		}
	}
	printf("The number of word is:%d",num);
}
