#include <stdio.h>
#include <string.h>
void main()
{
	char ch1[30]="the republic ";
	char ch2[30]="of China.";
	int i,j,k,t=0;
	i=strlen(ch1);
	j=strlen(ch2);
	for(k=i;k<i+j;k++)
		ch1[k]=ch2[t++];
	printf("%s",ch1);	
}
