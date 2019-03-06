#include <stdio.h>
int M=9;
int N=9;
float pingjun(int x,float a[][5]);
float kepj(int k,float a[][5]);
float high(float a[][5])
{
	int i,j;
	float max=a[0][0];
	for(i=0;i<10;i++)
	{
		for(j=0;j<5;j++)
		{
			if(max<a[i][j])
			{
				max=a[i][j];
				M=i;N=j;
			}
		}
	}
	return max;
}
float fangcha(float a[][5]);
void main()
{
	float a[10][5];
	float p;
	int i,j;
	printf("Please input 50 numbers:");
	for(i=0;i<10;i++)
		for(j=0;j<5;j++)
			scanf("%f",&a[i][j]);
	printf("十个同学的平均分分别是：");
	for(i=0;i<10;i++)
		printf("%-7.2f",pingjun(i,a));
	printf("\n");
	printf("每门课的平均分是：");
	for(i=0;i<5;i++)
		printf("%-5.2f  ",kepj(i,a));
	printf("\n");
	p=high(a);
	printf("最高分是%-3.2f,是第%d个学生的第%d门课程。",p,M+1,N+1);
	printf("\n");
	printf("平均分方差是：");
	printf("%-7.2f",fangcha(a));
}
float pingjun(int x,float a[][5])
{
	int i;
	float sum=0;
	for(i=0;i<5;i++)
		sum=sum+a[x][i];
	return sum/5;
}
float kepj(int k,float a[][5])
{
	int i;
	float sum=0;
	for(i=0;i<10;i++)
		sum=sum+a[i][k];
	return sum/10;
}
float fangcha(float a[][5])
{
	int i;
	float sum=0;
	for(i=0;i<1;i++)
		sum=sum+pingjun(i,a)*pingjun(i,a);
	return (sum/10)-(sum/100);
}
