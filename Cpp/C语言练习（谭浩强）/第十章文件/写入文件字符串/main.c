#include <stdio.h>
#include <stdlib.h>
#include <string.h>
void main()
{
	FILE *fp;
	char str[3][10],temp[10];
	int i,j;
	for(i=0;i<3;i++)
		gets(str[i]);
	for(i=0;i<2;i++)
	{	
		for(j=0;j<2-i;j++)
		{	
			if(strcmp(str[j],str[j+1])>0)
			{
				strcpy(temp,str[j]);
				strcpy(str[j],str[j+1]);
				strcpy(str[j+1],temp);
			}
		}
	}
	if((fp=fopen("file.txt","w"))==NULL)
	{
		printf("error");
		exit(0);
	}
	for(i=0;i<3;i++)
	{
		fputs(str[i],fp);
		fputs("\n",fp);
		puts(str[i]);
	}
	fclose(fp);
}
