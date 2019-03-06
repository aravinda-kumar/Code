#include<stdio.h>
#include<string.h>
int Num=0;
int Alp=0;
int Spa=0;
int Oth=0;
void acc(int x,char a[])
{
	int i;
	for(i=0;i<x;i++)
	{
		if((a[i]>='a'&&a[i]<='z')||(a[i]>='A'&&a[i]<='Z'))	Alp++;
		else	if(a[i]>='0'&&a[i]<='9')	Num++;
		else	if(a[i]==32)	Spa++;
		else	Oth++;
	}
}
void main()
{
	char ch[80];
	int i;
	printf("Please input a string:");
	gets(ch);
	i=strlen(ch);
	acc(i,ch);
	printf("The number of numbers is:%d\n",Num);
	printf("The number of alpabets is:%d\n",Alp);
	printf("The number of spaces is:%d\n",Spa);
	printf("The number of other charactoes is:%d\n",Oth);
}
