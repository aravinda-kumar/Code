#include <stdio.h>
int max(int n,int a[][4]);
void main()
{
	int c[3][4]={1,3,5,7,2,4,60,8,15,17,34,12};
	int big;
	big=max(3,c);
	printf("The largest number is:%d",big);
}

int max(int n,int a[][4])
{
	int i,j,k;
	k=a[0][0];
	for(i=0;i<n;i++)
	{
		for(j=0;j<4;j++)
			if(k<a[i][j])
				k=a[i][j];
	}
	return k;
}
