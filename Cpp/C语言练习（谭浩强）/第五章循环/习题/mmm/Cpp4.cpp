#include "stdio.h"
int main()
{
	char a;
	int q,s,r,t;
	scanf("%c",&a);
	q=0;s=0;r=0;t=0;
	while(a!='\n')
	{
		if((a>='A'&&a<='Z')||(a>='a'&&a<='z'))
			q=q+1;
		else
		{
		if(a==32)
			s=s+1;
		else
			if(a>='0'&&a<='9')
			r=r+1;
		else
			t=t+1;
		}
		scanf("%c",&a);
	}
	printf("中英文字母个数：%d\n",q);
	printf("空格个数：%d\n",s);
	printf("数字个数：%d\n",r);
	printf("其他字符个数：%d\n",t);
	return 0;
}
		

		

