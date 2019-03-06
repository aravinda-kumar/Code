#include <stdio.h>
void main()
{
	char str[3][80]={{'A','S','S',' ','.',',','s','d','w','3','4','5','7','0'},
					 {'A','S','S',' ','.',',','s','d','w','3','4','5','7','0'},
					 {'A','S','S',' ','.',',','s','d','w','4','5','7','0','0'}};
	char c;
	int balp=0,salp=0,num=0,spa=0,oth=0;
	int i,j;
	for(i=0;i<3;i++)
	{
		for(j=0;str[i][j]!='\0';j++)
		{
			c=str[i][j];
			if(c>='A'&&c<='Z')			balp++;
			else	if(c>='a'&&c<='z')	salp++;
			else	if(c>='0'&&c<='9')	 num++;	
			else	if(c==32)			 spa++;	
			else	oth++;			
		}
	}
	printf("大写字母的个数是：%d\n",balp);
	printf("小写字母的个数是：%d\n",salp);
	printf("数字的个数是：%d\n",num);
	printf("空格的个数是：%d\n",spa);
	printf("大其他字符的个数是：%d",oth);
} 
