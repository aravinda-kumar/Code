#include <stdio.h>
#include <string.h>
void main()
{
	char ch1[30];
	char ch2[30];
	printf("Please input the first string:");
	gets(ch1);
	printf("Please input the second string:");
	gets(ch2);
	int i,j,k,t,m;
	i=strlen(ch1);
	j=strlen(ch2);
	if(i<j)		k=j;
	else		k=i;
	for(t=0;t<k;t++)
	{
		m=ch1[t]-ch2[t];
		if(m!=0)		
		{		
			if(m<0)
				printf("ch1 is smaller than ch2\n");
			else
				printf("ch1 is bigger than ch2\n");
		break;
		}
	}	
	if(t==k)
		printf("ch1 is equal to ch2\n");
	printf("The number is:%d",m);
}
