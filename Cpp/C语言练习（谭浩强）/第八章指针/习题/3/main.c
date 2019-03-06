#include <stdio.h>
void exchange (int *p,int n);
void input(int *p,int n);
void print(int *p,int n);
void main()
{
	int a[10];
	input(a,10);
	exchange(a,10);
	print(a,10);
}
void input(int *p,int n)
{
	int i;
	for(i=0;i<n;i++)
		scanf("%d",p++);
}
void exchange (int *p,int n)
{
	int min,max,i,k,t,temp;
	min=*p;
	max=*p;
	for(i=0;i<n;i++)
	{
		if(min>*(p+i))
		{
			min=*(p+i);
			k=i;
		}
		if(max<*(p+i))
		{
			max=*(p+i);
			t=i;
		}
	}
	temp=*p;*p=*(p+k);*(p+k)=temp;
	temp=*(p+n-1);*(p+n-1)=*(p+t);*(p+t)=temp;
}
void print(int *p,int n)
{
	int i;
	for(i=0;i<n;i++)
		printf("%d\t",*(p+i));
}
