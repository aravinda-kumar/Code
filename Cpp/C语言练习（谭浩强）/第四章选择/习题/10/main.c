#include <stdio.h>
#include <stdlib.h>
void main()
{
	int bbond,n;
	float i,bond;
	bbond=100000*0.1;
	scanf("%f",&i);
	if(i<=100000)
	{
		bond=i*0.1;
	}
	else
	{
		if(i>100000&&i<=200000)
		{
			bond=bbond+(i-100000)*0.075;
		}
		else
		{
			if(i>200000&&i<=400000)
			{
				bond=bbond+100000*0.075+(i-200000)*0.05; 
			}
			else
			{
				if(i>400000&&i<=600000)
				{
					bond=bbond+100000*0.075+200000*0.05+(i-400000)*0.03;
				}
				else
				{
					if(i>600000&&i<=1000000)
					{
						bond=bbond+100000*0.075+200000*0.08+(i-600000)*0.015;	
					}
					else
					{
						if(i>=1000000)
						{
							bond=bbond+100000*0.075+200000*0.08+(400000)*0.015*(i-1000000)*0.01;
						}
					}
				} 
			} 
		}
	}
	printf("奖金的总额是：%-7.2f\n",bond);
	if(i<=100000)
	{
		n=0;
	}
	else
	{
		if(i>100000&&i<=200000)
		{	
			n=1;
		}
		else
		{
			if(i>200000&&i<=400000)
			{
				n=2;
			}
			else
			{
				if(i>400000&&i<=600000)
				{
					n=3;
				}
				else
				{
					if(i>600000&&i<=1000000)
					{
						n=4;
					}
					else
					{
						if(i>=1000000)
						{
							n=5;
						}
					}
				}
			}
		}
	}
	switch(n)
	{
		case 0:bond=i*0.1;break;
		case 1:bond=bbond+(i-100000)*0.075;break;
		case 2:bond=bbond+100000*0.075+(i-200000)*0.05; break;
		case 3:bond=bbond+100000*0.075+200000*0.05+(i-400000)*0.03;break;
		case 4:bond=bbond+100000*0.075+200000*0.08+(i-600000)*0.015;break;
		case 5:bond=bbond+100000*0.075+200000*0.08+(400000)*0.015*(i-1000000)*0.01;break;
	}
	printf("奖金的总额是：%-7.2f",bond);
}
