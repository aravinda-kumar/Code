#include <stdio.h>
#include <stdlib.h>
void main()
{
	int x,y;
	printf("enter x:");
	scanf("%d",&x);
	y=0;
	if(x>=0)
		if(x>0) y=1;
	else y=-1;
	printf("x=%d,y=%d",x,y);
}
