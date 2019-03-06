#include<stdio.h>
void main()
{
	int i;
	float aver,sum,amount;
	sum=0;
	for(i=1;i<10000;i++)
	{
		printf("ÇëÊäÈëÊı¶î£º");
		scanf("%f",&amount);
		sum=sum+amount;
		if(sum>100000)
			break;
	}
	aver=sum/i;
	printf("i=%d\naver=%-7.2f",i,aver);
}
