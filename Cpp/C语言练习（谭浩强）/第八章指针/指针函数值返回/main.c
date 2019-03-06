#include <stdio.h>
int *search1(int (*p)[4],int n);
int *search(int (*p)[4],int n);
int *search2(int (*p)[4]);
void main()
{
	int a[3][4]={60,70,80,90,56,89,67,88,34,78,90,66};
	int (*p)[4],*p1;
	int i;
	p=a;
	p1=search1(p,2);
	for(i=0;i<4;i++)
		printf("%d\t",*(p1+i));
	printf("\n");
	printf("**********************************\n");
	int *p3;
	int j;
	for(i=0;i<3;i++)
	{
		p3=search(a,i);
		if(p3==a+i)
		{
			for(j=0;j<4;j++)
				printf("%d\t",*(p3+j));
			printf("\n");
		}
	}
		printf("\n");
	printf("**********************************\n");
	int k,m;
	int *p4;
	for(k=0;k<3;k++)
	{
		p4=search2(a+k);
		if(p4==*(a+k))		
			for(m=0;m<4;m++)
				printf("%d\t",*(p4+m));		
		printf("\n");
	}
	
}
int *search1(int (*p)[4],int n)
{
	return *(p+n);
}
int *search(int (*p)[4],int n)
{
	int i,m;
	int *pt;
	for(i=0;i<4;i++)
	{
		m=*(*(p+n)+i);
		if(m<60)	
		{
			pt=*(p+n);
			break;
		}
		else	pt=NULL;
	}
	return pt;
}
int *search2(int (*p)[4])
{
	int *pt;
	int i;
	pt=NULL;
	for(i=0;i<4;i++)
	{
		if(*(*p+i)<60)
			pt=p;
	}
	return pt;
}
