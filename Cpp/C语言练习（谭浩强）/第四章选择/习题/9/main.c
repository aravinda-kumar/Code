#include <stdio.h>
#include <stdlib.h>
void main()
{
	unsigned int a,b,c,d,e,f,g;
	printf("Please input a valid number:");
	scanf("%d",&a);
	if(a>=0&&a<=9)
	{
		printf("这是一个一位数\n"); 
	}
	if(a>=10&&a<=99)
	{
		printf("这是一个俩位数\n"); 
		e=a/10;
		f=a%10;
		
		g=f*10+e;
		printf("十位数=%d   个位数=%d\n",e,f);
		printf("重新组合后的数字为：%d",g);
	}
	if(a>=100&&a<=999)
	{
		printf("这是一个三位数\n"); 
		d=a/100;
		e=a%100/10;
		f=a%100%10;
		
		g=f*100+e*10+d;
		printf("百位数=%d   十位数=%d   个位数=%d\n",d,e,f);
		printf("重新组合后的数字为：%d",g);
	}
	if(a>=1000&&a<=9999)
	{
		printf("这是一个四位数\n"); 
		c=a/1000;
		d=a%1000/100;
		e=a%100/10;
		f=a%100%10;
		
		g=f*1000+e*100+d*10+c;
		printf("千位数=%d   百位数=%d   十位数=%d   个位数=%d\n",c,d,e,f);
		printf("重新组合后的数字为：%d",g);
	}
	if(a>=10000&&a<=99999)
	{
		printf("这是一个五位数\n"); 
		b=a/10000;
		c=a%10000/1000;
		d=a%1000/100;
		e=a%100/10;
		f=a%10;
		
		g=f*10000+e*1000+d*100+c*10+b;
		printf("万位数=%d   千位数=%d   百位数=%d   十位数=%d   个位数=%d\n",b,c,d,e,f);
		printf("重新组合后的数字为：%d",g);
	}
}
