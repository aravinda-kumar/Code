#include <stdio.h>
void shuru(int x,char ch[][2]);

void main()
{
	char ch[10][2];
	int i,j;
	for(i=0;i<10;i++)
		shuru(i,ch);
	printf("*************************\n");
	for(i=0;i<10;i++)
	{
		for(j=0;j<2;j++)
			printf("%c\t",ch[i][j]);
		printf("\n");
	}
}
void shuru(int x,char ch[][2])
{
	gets(ch);
}
