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
	printf("��ĸ�ĸ����ǣ�%d\n",alp);
	printf("���ֵĸ����ǣ�%d\n",num);
	printf("�ո�ĸ����ǣ�%d\n",spa);
	printf("�����ַ��ĸ����ǣ�%d",oth);
}
