#include <stdio.h>
void average(float (*p)[4],int n);
void search(float (*p)[4],int n);
void main()
{
	float a[3][4]={65,67,70,60,80,87,90,81,90,99,100,98};
	int i,j;
//	average(*a,12);
	average(a,12);
	search(a,2);
} 
//void average(float *p,int n)
//{
//	int i;
//	float *pend;
//	float sum=0,ave;
//	pend=p+n;
//	for(;p<pend;p++)
//		sum=sum+*p;
//	ave=sum/n;
//	printf("The average number is:%-7.2f",ave);
//	printf("\n");
//}
void average(float (*p)[4],int n)
{
	int i,j;
	float sum=0,ave;
	for(i=0;i<3;i++)
		for(j=0;j<4;j++)
			sum=sum+(*(*(p+i)+j));
	ave=sum/n;
	printf("The average number is:%-7.2f",ave);
	printf("\n");
}  
void search(float (*p)[4],int n)
{
	int i;
	printf("The numbers in line %d is:",n);
	for(i=0;i<4;i++)
		printf("%-3.1f\t",*(*(p+n)+i));
}
