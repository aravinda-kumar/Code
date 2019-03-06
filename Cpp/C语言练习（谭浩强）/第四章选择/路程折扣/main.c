#include <stdio.h>
#include <stdlib.h>
void main()
{
	int kilo,dsnum;
	float p,w,sum,discount;
	printf("请输入基本运费，货物重量，距离:");
	scanf("%f %f %d",&p,&w,&kilo);
	if(kilo<0)
	{	
		printf("ERROR!");
	}
	else
	{	
		if(kilo>=0)
			{
				if(kilo<250)
				{
				dsnum=0;
				}	
				else
				{
					if(kilo<500)
					{
						dsnum=1;
					}
					else
					{	
						if(kilo<1000)
						{
							dsnum=2;
						}
						else
						{
							if(kilo<2000)
							{
								dsnum=3;
							}
							else
							{
								if(discount<3000)	
								{
								dsnum=4;
								}
								else
								{
									dsnum=5;
								}
							}
						}
					}
				}
			}	
		switch(dsnum)
		{
			case 0:discount=0;break;
			case 1:discount=2;break;
			case 2:discount=5;break;
			case 3:discount=8;break;
			case 4:discount=10;break;
			case 5:discount=15;break;
		}
		sum=p*w*kilo*(1-discount/100.0);
		printf("The whole price is:%-7.2f",sum);
	}
} 
