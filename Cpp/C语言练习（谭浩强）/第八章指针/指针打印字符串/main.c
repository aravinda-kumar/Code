#include <stdio.h>
void main()
{
	char a[]="I am a student!";
	char b[20];
	int i;
	for(i=0;*(a+i)!='\0';i++)
		*(b+i)=*(a+i);
	*(b+i)='\0';
	printf("string is:%s\n",a);
	printf("string is:");
	for(i=0;*(b+i)!='\0';i++)
		printf("%c",*(b+i));
	printf("\n");
	printf("**************************************\n");
	char *p1,*p2;
	p1=a;p2=b;
	for(i=0;*(p1+i)!='\0';i++)
		*(p2+i)=*(p1+i);
	*(p2+i)='\0';
	printf("string is:%s",b);
	printf("\n");
	printf("**************************************\n");
	char *p3,*p4;
	p3=a;p4=b;
	for(;*p3!='\0';p3++,p4++)
		*p4=*p3;
	*p4='\0';
	printf("string is:%s",b);
}
