#include <stdio.h>
#include <stdlib.h>
void comp(int *p);
void main()
{
	int *p;
	int i;
//	p=(int *)malloc(5*sizeof(int));	 //The size of allocated memory is based on int 
	p=(int *)malloc(5);	     //The size of allocated memory is based on byte
	printf("Please input 5 scores:");
	for(i=0;i<5;i++)
		scanf("%d",p+i);
	comp(p);
}
void comp(int *p)
{
	int i;
	printf("These scores are below 60:");
	for(i=0;i<5;i++)
	{
		if(*(p+i)<60)
			printf("%d\t",*(p+i));
	}
}
