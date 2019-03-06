#include <stdio.h>
#include <stdlib.h>
void main()
{
	FILE *fpa,*fpb,*fpc;
	char ch;
	if((fpa=fopen("A.txt","r"))==NULL)
	{
		printf("error!");
		exit(0);
	}
	if((fpb=fopen("B.txt","r"))==NULL)
	{
		printf("error!");
		exit(0);
	}
	if((fpc=fopen("C.txt","w"))==NULL)
	{
		printf("error!");
		exit(0);
	}
	while(!feof(fpa))
	{
		ch=getc(fpa);
		fputc(ch,fpc);
	}
	while(!feof(fpb))
	{
		ch=getc(fpb);
		fputc(ch,fpc);
	}
	fclose(fpa);
	fclose(fpb);
	fclose(fpc);
}
