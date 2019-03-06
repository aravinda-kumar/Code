#include <stdio.h>
#include <string.h>
char deletech(char ch[]);
char c;
void main()
{
	char ch[30];
	int i;
	printf("Please input a string:");
	gets(ch);
	printf("Please input a chararctor:");
	c=getchar();
	deletech(ch);
	printf("%d\n",strlen(ch));
	printf("%s",ch);
}
char deletech(char ch[30])
{
		int i,n;
		for(i=0;ch[i]!='\0';i++)
		{
			if(ch[i]==c)
			{
				for(n=i;ch[n]!='\0';n++)
					ch[n]=ch[n+1];
			}
		}
}
