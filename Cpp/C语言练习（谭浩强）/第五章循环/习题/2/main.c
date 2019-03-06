#include <stdio.h>
#include <math.h>
void main()
{
	int i=1,flag=1,num=0;
	float pi=0,fz=1.0,zh;
	zh=1;
	while(fabs(zh)>1e-6)
	{
		zh=fz/i;
		zh=zh*flag;
		pi=pi+zh;
		flag=flag*(-1);
		i=i+2;
		num++;
	}
	pi=4*pi;
	printf("%f\n",pi);
	printf("%d",num
	);
}
