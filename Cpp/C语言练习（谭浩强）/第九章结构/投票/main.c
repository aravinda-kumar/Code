#include <stdio.h>
#include <string.h>
void main()
{
	struct Person{
					char name[30];
					int count;
	}leader[3]={"li",0,"zhang",0,"du",0};
	int i,j;
	char name[20];
	for(j=0;j<10;j++)
	{
		scanf("%s",name);
		for(i=0;i<3;i++)
		{
			if(strcmp(name,leader[i].name)==0)	leader[i].count++;	
		}
	}
	printf("The result is:\n");
	for(i=0;i<3;i++)
	{
		printf("%s:%d\n",leader[i].name,leader[i].count);	
	}
}
