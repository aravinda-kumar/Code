#include <stdio.h>
void change(int (*p)[5],int n);
void main()
{
	int a[5][5]={ 8, 5,18,16,10,6, 7, 1, 9, 2,11,12,13,14,15,4,17, 3,19,20,21,22,25,24,23};
	int i,j;
	change(a,5);
	printf("The sorted array is:\n");
	for(i=0;i<5;i++)
	{
		for(j=0;j<5;j++)
			printf("%d\t",*(*(a+i)+j));
		printf("\n");
	}
}
void change(int (*p)[5],int t)
{
	int i,j,m,n,k;
	int max;
	max=*(*p);
	for(i=0;i<5;i++)
	{
		for(j=0;j<t;j++)
		{
			if(max<*(*(p+i)+j))
			{
				max=*(*(p+i)+j);
				m=i;n=j;
			}
		}
	} 
	k=*(*(p+2)+2);*(*(p+2)+2)=*(*(p+m)+n);*(*(p+m)+n)=k;
	int min;
	min=*(*p);
	for(i=0;i<5;i++)
	{
		for(j=0;j<t;j++)
		{
			if(min>=*(*(p+i)+j))
			{
				min=*(*(p+i)+j);
				m=i;n=j;
			}
		}
	} 
	k=*(*(p+0)+0);*(*(p+0)+0)=*(*(p+m)+n);*(*(p+m)+n)=k;
	int sec;
	sec=*(*p+1);
	for(i=0;i<5;i++)
	{
		for(j=1;j<t;j++)
		{
			if(sec>=*(*(p+i)+j))
			{
				sec=*(*(p+i)+j);
				m=i;n=j;
			}
		}
	} 
	k=*(*(p+0)+4);*(*(p+0)+4)=*(*(p+m)+n);*(*(p+m)+n)=k;
	int thr;
	thr=*(*p+1);
	for(i=0;i<5;i++)
	{
		for(j=0;j<t;j++)
		{
			if((i==0&&j==4)||(i==0&&j==0))
				continue; 
			else
			{
				if(thr>=*(*(p+i)+j))
				{
					thr=*(*(p+i)+j);
					m=i;n=j;
				}
			}
		}
	} 
	k=*(*(p+4)+0);*(*(p+4)+0)=*(*(p+m)+n);*(*(p+m)+n)=k;
	int fo;
	fo=thr+1;
	for(i=0;i<5;i++)
	{	
		for(j=0;j<t;j++)
		{	
			if((i==0&&j==4)||(i==4&&j==0)||(i==0&&j==0))
				continue; 
			else
			{	
				if(fo>=*(*(p+i)+j))
				{	
					fo=*(*(p+i)+j);
					m=i;n=j;
				}
			}
		}
	} 
	k=*(*(p+4)+4);*(*(p+4)+4)=*(*(p+m)+n);*(*(p+m)+n)=k;
}
