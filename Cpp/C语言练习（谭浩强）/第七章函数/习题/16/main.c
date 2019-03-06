#include <stdio.h>
void main()
{
	int a;
	printf("输入一个十六进制数：");
	scanf("%x",&a);
	a=a*16;
	printf("%d",a);
}
