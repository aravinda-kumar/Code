#include <stdio.h>
#include <stdlib.h>
void main()
{
	unsigned int a,b,c,d,e,f,g;
	printf("Please input a valid number:");
	scanf("%d",&a);
	if(a>=0&&a<=9)
	{
		printf("����һ��һλ��\n"); 
	}
	if(a>=10&&a<=99)
	{
		printf("����һ����λ��\n"); 
		e=a/10;
		f=a%10;
		
		g=f*10+e;
		printf("ʮλ��=%d   ��λ��=%d\n",e,f);
		printf("������Ϻ������Ϊ��%d",g);
	}
	if(a>=100&&a<=999)
	{
		printf("����һ����λ��\n"); 
		d=a/100;
		e=a%100/10;
		f=a%100%10;
		
		g=f*100+e*10+d;
		printf("��λ��=%d   ʮλ��=%d   ��λ��=%d\n",d,e,f);
		printf("������Ϻ������Ϊ��%d",g);
	}
	if(a>=1000&&a<=9999)
	{
		printf("����һ����λ��\n"); 
		c=a/1000;
		d=a%1000/100;
		e=a%100/10;
		f=a%100%10;
		
		g=f*1000+e*100+d*10+c;
		printf("ǧλ��=%d   ��λ��=%d   ʮλ��=%d   ��λ��=%d\n",c,d,e,f);
		printf("������Ϻ������Ϊ��%d",g);
	}
	if(a>=10000&&a<=99999)
	{
		printf("����һ����λ��\n"); 
		b=a/10000;
		c=a%10000/1000;
		d=a%1000/100;
		e=a%100/10;
		f=a%10;
		
		g=f*10000+e*1000+d*100+c*10+b;
		printf("��λ��=%d   ǧλ��=%d   ��λ��=%d   ʮλ��=%d   ��λ��=%d\n",b,c,d,e,f);
		printf("������Ϻ������Ϊ��%d",g);
	}
}
