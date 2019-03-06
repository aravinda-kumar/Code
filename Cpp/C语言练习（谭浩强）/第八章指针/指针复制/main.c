#include <stdio.h>
copystring(char *p1,char *p2);
void main()
{
	char *p="I am a student!";
	char b[20]="You are a student!";
	char *m;
	printf("The string p is:%s\nThe string b is:%s\n",p,b);
	m=b;
	copystring(p,b);
	printf("*******************************\n");
	printf("The string p is:%s\nThe string b is:%s\n",p,b);
}
copystring(char *p1,char *p2)
{
	for(;*p1!='\0';p1++,p2++)
		*p2=*p1;
	*p2='\0';
}
