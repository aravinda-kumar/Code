#include <stdio.h>
void main()
{
	int num=0,alp=0,spa=0,oth=0;
	char ch;
	ch=getchar();
	while(ch!='\n')
	{
		if(ch>='a'&&ch<='z'||ch>='A'&&ch<='Z')
			alp++;
		else
		{
			if(ch>='0'&&ch<='9')
				num++;
			else
			{
				if(ch==' ')               //or  if(ch==32)
					spa++;
				else 
					oth++;
			}
		}
		ch=getchar();
	}
	printf("字母的个数是：%d\n",alp);
	printf("数字的个数是：%d\n",num);
	printf("空格的个数是：%d\n",spa);
	printf("其他字符的个数是：%d",oth);
}
