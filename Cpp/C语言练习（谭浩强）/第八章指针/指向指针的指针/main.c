#include <stdio.h>
void main()
{
	char * name[5]={"Follow me","BASIC","Great Wall","FORTRAN","Computer desingn"};
	char **p;
	int i;
	p=name;
	for(i=0;i<5;i++)
	{
		printf("%s\n",*(p+i));
	}
}
