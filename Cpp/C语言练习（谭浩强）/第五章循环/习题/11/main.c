#include <stdio.h>
void main()
{
	float a=100;
	int i,n;
	float sh,height;
	height=a;
	sh=a;
	n=20;
	if(n==1)
		height=a;
	else
	{
		for(i=2;i<=n;i++)
		{
			sh=sh/2.0;
			height=height+2*sh;
		}	
	}
	printf("��ʮ�����ʱ����%15.9f�ס�\n",height);
	printf("��ʮ�η����߶�Ϊ%15.9f�ס�",sh/2);
}
