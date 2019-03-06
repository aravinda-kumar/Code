#include <stdio.h>
void chai(int x,char a[])
{
	int i,m=1000;
	for(i=0;i<7;i=i+1)
	{
		if(i%2==0)
		{	
			x=x%(m*10);
			a[i]=x/m+48;
			m=m/10;
		}
		else 
			a[i]=32;
	}
	a[i]='\0';
}
void main()
{
	int a;
	char ch[30];
	printf("Please input a number:");
	scanf("%d",&a);
	chai(a,ch);
	printf("%s",ch); 
}
