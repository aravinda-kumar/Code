#include <stdio.h>
#include <stdlib.h>
void main()
{
	FILE *in,*out;
	char ch;
	if((in=fopen("file.txt","r"))==NULL)
	{
		printf("error!");
		exit(0);
	}
	if((out=fopen("file1.txt","w"))==NULL)
	{
		printf("error!");
		exit(0);
	}
	while(!feof(in))
	{
		ch=fgetc(in);
		fputc(ch,out);
		putchar(ch);
	}
	fclose(in);
	fclose(out);
}
