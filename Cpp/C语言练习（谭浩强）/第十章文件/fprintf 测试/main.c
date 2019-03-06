#include <stdio.h>
#include <stdlib.h>
void main()
{
	FILE *in,*out;
//	if((in=fopen("file.txt","w"))==NULL)
//	{
//		printf("erroe!");
//		exit (0);
//	}
//	int i=3,j=4;
//	fprintf(in,"%d  %d",i,j);
	int a,b;
	if((out=fopen("file.txt","w"))==NULL)
	{
		printf("erroe!");
		exit (0);
	}
	fsc9anf(out,"%d %d",&a,&b);
	printf("%d  %d",a,b);
}
