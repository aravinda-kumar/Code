#include <stdio.h>
#include <stdlib.h>
void main()
{
	FILE *fp;
	char str[3][10];
	int i;
	if((fp=fopen("file.txt","r"))==NULL)
	{
		printf("error!");
		exit(0);
	}
	for(i=0;i<3;i++)
		printf("%s",fgets(str[i],10,fp));
	fclose(fp);
}
