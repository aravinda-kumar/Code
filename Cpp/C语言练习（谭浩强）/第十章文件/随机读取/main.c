#include <stdio.h>
#include <stdlib.h>
void main()
{
	FILE *fp1,*fp2;
	char ch;
	if((fp1=fopen("file.txt","r"))==NULL)
	{
		printf("error!");
		exit (0);
	}
	if((fp2=fopen("file1.txt","w"))==NULL)
	{
		printf("error!");
		exit (0);
	}
	while(!feof(fp1))	putchar(fgetc(fp1));
	rewind(fp1);
	while(!feof(fp1))
	{
		ch=fgetc(fp1);
		fputc(ch,fp2);
	}
	fclose(fp1);
	fclose(fp2);
}
