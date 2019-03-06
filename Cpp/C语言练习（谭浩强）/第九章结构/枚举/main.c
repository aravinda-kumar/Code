#include <stdio.h>
void main()
{
	enum {red,yellow,blue,white,black}i,j,k,pri;
	int n=0,loop;
	for(i=red;i<=black;i++)
	{
		for(j=red;j<=black;j++)
		{
			if(i!=j)
			{
				for(k=red;k<=black;k++)
				{
					if(k!=j&&k!=i)
					{
						n++;
						for(loop=1;loop<=3;loop++)
						{
							switch(loop)
							{
								case 1:pri=i;break;
								case 2:pri=j;break;
								case 3:pri=k;break;
								default :break;
							}
							switch(pri)
							{
								case red:printf("red       ");break;
								case yellow:printf("yellow    ");break;
								case blue:printf("blue      ");break;
								case white:printf("white     ");break;
								case black:printf("black     ");break;
							}
						}
						printf("\n");
					}
				}
			}
		}
	}
	printf("The figure is:%d",n);
}
