#include <stdio.h>
void main()
{
	int a,b;
	int i,j,m;
	printf("������������������");
	scanf("%d %d",&a,&b);
	if(a>=b)
	{
		j=a;i=b;
	}
	else
	{
		j=b;i=a;
	}
	for(;i>0;i--)
	{
		if((a%i)==0&&(b%i)==0)
			break;
	}
	for(;;j++)
	{
		if((j%a)==0&&(j%b)==0)
			break;
	}
	printf("���Լ��=%d\n",i);
	printf("��С������=%d\n",j);
}
