#include <stdio.h>
void exchange(int (*p)[3]);
void main()
{
	int a[3][3]={1,2,3,4,5,6,7,8,9};
	int i,j;
	exchange(a);
	for(i=0;i<3;i++)
	{
		for(j=0;j<3;j++)
			printf("%d\t",*(*(a+i)+j));
		printf("\n");
	}
}
void exchange(int (*a)[3])
{
	int i,j,k;
	for(i=0;i<3;i++)
	{
		for(j=i;j<3;j++)
		{
			k=*(*(a+i)+j);
			*(*(a+i)+j)=*(*(a+j)+i);
			*(*(a+j)+i)=k;
		}
	} 
} 
