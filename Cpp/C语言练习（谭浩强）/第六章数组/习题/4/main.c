#include <stdio.h>
void main()
{
	int b[11]={1,2,3,4,5,6,8,9,10,11};
	int i,a,j;
	printf("Please input a number:");
	scanf("%d",&a);
	for(i=0;i<11-1;i++)
	{
		if(a<=b[i])
		{
			for(j=10;j>i;j--)
				b[j]=b[j-1];
			b[i]=a;
			break;
		}
	}
	for(i=0;i<11;i++)
		printf("%d\t",b[i]);
}
