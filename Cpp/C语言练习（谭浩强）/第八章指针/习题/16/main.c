#include <stdio.h>
void tongji(char *p);
void main()
{
	char ch[]="a123x456 7689+89=321/ab23";
	tongji(ch);
}
void tongji(char *p)
{
	int i,j=0,k,num=0;
	int nnum=0;
	int a[30];
	int *pa;
	pa=a;
	for(i=0;*(p+i)!='\0';i++)
	{
		if((*(p+i)>='0')&&(*(p+i)<='9'))
				j++;
		else
		{	
			if(j>0)
			{
				for(k=0;k<j;k++)
					num=num*10+(*(p+i-j+k)-48);
				j=0;
				*pa++=num;
				num=0;
				nnum++;
			}
		}
	}
	if(j>0)
	{
		for(k=0;k<j;k++)
			num=num*10+(*(p+i-j+k)-48);
		j=0;
		*pa=num;
		num=0;
		nnum++;
	}
	printf("There are %d number(s):",nnum);
	for(i=0;i<nnum;i++)
		printf("%d\t",a[i]);
}
