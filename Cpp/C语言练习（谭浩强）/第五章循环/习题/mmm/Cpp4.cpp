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
	printf("��Ӣ����ĸ������%d\n",q);
	printf("�ո������%d\n",s);
	printf("���ָ�����%d\n",r);
	printf("�����ַ�������%d\n",t);
	return 0;
}
		

		

