#include <stdio.h>
#include <stdlib.h>
void main()
{
	FILE *fp;
	int i;
	char ch;
	if((fp=fopen("file.txt","w"))==NULL)
	{
		printf("error!");
		exit(0);
	}
	ch=getchar();
	while(ch!='!')
	{
		ch=ch-32;
		putc(ch,fp);
		ch=getchar();		
	}
	fclose(fp);
}
