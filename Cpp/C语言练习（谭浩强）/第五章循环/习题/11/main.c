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
	printf("第十次落地时经过%15.9f米。\n",height);
	printf("第十次反弹高度为%15.9f米。",sh/2);
}
