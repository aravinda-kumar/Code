#include <stdio.h>
//void search(float (*p)[4],int n);
void search(float *p,int n);
void main()
{
	float a[3][4]={65,57,70,60,68,87,90,81,90,49,100,98};
//	search(a,3);
	search(a[0],12);
}
//void search(float (*p)[4],int n)
//{
//	int i,j,t;
//	float m;
//	for(i=0;i<n;i++)
//	{
//		for(j=0;j<4;j++)
//		{
//			m=*(*(p+i)+j);
//			if(m<60)
//			{
//				printf("NO.%d failed student is:",i+1);
//				for(t=0;t<4;t++)
//					printf("%-3.2f\t",*(*(p+i)+t));
//				printf("\n");				
//			}
//		}
//	}
//}
void search(float *p,int n)
{
	int i,j;
	float m;
	float *pend=p+12;
	float *sp;
	sp=p;
	for(;sp<pend;sp++)
	{
		if(*sp<60)
		{
			m=sp-p;
			if(m>=0&&m<=3)
			{
				i=0;
				printf("NO.1 failed student is:");
				for(j=i;j<i+4;j++)
				printf("%-3.2f\t",*p++);
				printf("\n");
			}
			else
			{
				if(m>3&&m<=7)
				{
					i=4;
					p=p+4;
					printf("NO.2 failed student is:");
					for(j=i;j<i+4;j++)
					printf("%-3.2f\t",*p++);
					printf("\n");	
				}
				else
				{
					if(m>7&&m<=11)
					{
						i=8;
						p=p+8;
						printf("NO.3 failed student is:");
						for(j=i;j<i+4;j++)
						printf("%-3.2f\t",*p++);
						printf("\n");	
					}
				}
			}
		}
	}
}
