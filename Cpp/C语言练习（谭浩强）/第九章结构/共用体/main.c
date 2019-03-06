#include <stdio.h>
struct {
		char name[30];
		int num;
		char sex;
		char job;
		union {
			int clas;
//			char po[1];
			char pos;
		}lei;
}person[2];
void main()
{
	int i;
	for(i=0;i<2;i++)
	{
		scanf("%s %d %c %c",&person[i].name,&person[i].num,&person[i].sex,&person[i].job);
		{
			if(person[i].job=='s')
				scanf("%d",&person[i].lei.clas); 
			else
			{
				if(person[i].job=='t')
					scanf("%c",&person[i].lei.pos); 
//				printf("**************************************\n");
//				printf("%c\n",person[i].lei.pos);
			}
		}
	}
	for(i=0;i<2;i++)
	{
		if(person[i].job=='s')
			printf("%4s %3d %c %c %d\n",person[i].name,person[i].num,person[i].sex,person[i].job,person[i].lei.clas);
		if(person[i].job=='t')
			printf("%4s %3d %c %c %c\n",person[i].name,person[i].num,person[i].sex,person[i].job,person[i].lei.pos);
	} 
}
