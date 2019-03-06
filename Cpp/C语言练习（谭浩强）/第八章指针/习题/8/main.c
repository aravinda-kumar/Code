#include <stdio.h>
void tongji(char *p);
void main()
{
	char ch[]="johnson,19950810.zhu shuai ";
	tongji(ch);
}
void tongji(char *p)
{
	int i,j;
	int num,alp,spa,oth;
	num=0;alp=0;spa=0;oth=0;
	for(i=0;*(p+i)!='\0';i++)
	{
		if((*(p+i)>='a'&&*(p+i)<='z')||*(p+i)>='A'&&*(p+i)<='Z')	alp++;
		else	if(*(p+i)>='0'&&*(p+i)<='9')	num++;
		else	if(*(p+i)==32)	spa++;
		else	oth++;
	}
	printf("The number of alphbets is:%d\n",alp);
	printf("The number of numbers is:%d\n",num);
	printf("The number of space is:%d\n",spa);
	printf("The number of others is:%d\n",oth);
}
