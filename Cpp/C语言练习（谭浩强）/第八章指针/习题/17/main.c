#include <stdio.h>
int strcmp(char *p1,char *p2);
void main()
{
	char ch1[]="China";
	char ch2[]="China";
	int i;
	i=strcmp(ch1,ch2);
	printf("%d\n",i);
}
int strcmp(char *p1,char *p2)
{
	int i,t,j=0,k=0,m;
	for(i=0;*(p1+i)!='\0';i++)
		j++;
	for(i=0;*(p2+i)!='\0';i++)
		k++;
	if(j>k)	m=j;
	else	m=k;
	for(i=0;i<m;i++)
	{
		t=*(p1+i)-*(p2+i);
		if(t!=0)
			break;
	}
	if(i==m)	t=0;
	return t;
}
