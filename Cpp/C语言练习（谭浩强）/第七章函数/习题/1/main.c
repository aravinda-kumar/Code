#include <stdio.h>
int Max;
int Min;
void gbgy(int a,int b)
{
	int m;
	if(a>=b)
	{
		Max=a;Min=b;
	}
	else
	{
		Max=b;Min=a;
	}
	for(m=Max;;m++)
	{
		if(m%a==0&&m%b==0)
		{
			Max=m;
			break;
		}
	}
	for(m=Min;m>=1;m--)
	{
		if(a%m==0&&b%m==0)
		{
			Min=m;
			break;
		}
	}
}
void main()
{
	int a,b;
	printf("Please input 2 numbers:");
	scanf("%d%d",&a,&b);
	gbgy(a,b);
	printf("%d��%d�����Լ���ǣ�%d\n",a,b,Min);
	printf("%d��%d����С�������ǣ�%d\n",a,b,Max);
}
