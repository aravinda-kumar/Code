#include <stdio.h>
#include <string.h>
void main()
{
	char ch1[30]="johnson.Zhu\0huai";
	char ch2[30]="johnson.Zhus1234";
	int i,n,j,k,m;
	j=strlen(ch1);
	k=strlen(ch2);
	if(j>=k)	m=j;
	else		m=k;
	for(i=0;(ch1[i])!='\0';i++)
	{
		ch2[i]=ch1[i];
	}
	ch2[i]=ch1[i];
	for(n=0;n<m;n++)
		printf("%c",ch2[n]);
}
