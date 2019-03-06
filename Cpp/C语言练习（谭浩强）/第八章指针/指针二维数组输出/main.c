#include <stdio.h>
//void main()
//{
//	int a[3][4]={1,3,5,7,9,11,13,15,17,19,21,23};
//	int *p;
//	int i,j;
//	p=a;
//	for(i=0;i<3;i++)
//	{
//		for(j=0;j<4;j++)
//			printf("%d\t",*p++);
//		printf("\n");
//	}
//}

void main()
{
	int a[3][4]={1,3,5,7,9,11,13,15,17,19,21,23};
	int (*p)[4];
	int i,j;
	p=a;
	printf("Please input row and colum:");
	scanf("%d %d",&i,&j);
	printf("a[%d][%d]=%d",i,j,*(*(p+i)+j));
	
}
