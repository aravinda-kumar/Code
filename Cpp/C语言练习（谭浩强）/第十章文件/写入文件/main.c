#include <stdio.h>
#include <stdlib.h>
void main()
{
	FILE *fp;
	char ch,filename[10];
	printf("Please input the file name:");
	scanf("%s",filename);
	if((fp=fopen(filename,"w"))==NULL)
	{
		printf("error!");
		exit(0);
	}
	ch=getchar();
	printf("Please input charactet:");
	ch=getchar();
	while(ch!='#')
	{
		fputc(ch,fp);			//fgetc(fp)
		ch=getchar();
		putchar(ch);
	}
	fclose(fp);
}
