#include <stdio.h>
void search(char *p[],int n,int m);
void main()
{
	char *p[12]={"January","February","March","April",
				 "May","June","July","August",
				 "September","October","November","December"};
	int n;
	printf("Please input a number which is between 1 to 12:");
	scanf("%d",&n);
	search(p,12,n);
}
void search(char *p[],int n,int m)
{
	printf("%s\n",p[m-1]);
}
