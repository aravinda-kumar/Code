#include <stdio.h>
void main()
{
	struct student{
					int num;
					char name[30];
					int score;
	}student1,student2;
	int i;
		scanf("%d %s %d",&student1.num,student1.name,&student1.score);
		scanf("%d %s %d",&student2.num,student2.name,&student2.score);
		if(student1.score>student2.score)
			printf("num=%d\nname=%s\nscore=%d\n",student1.num,student1.name,student1.score);
		else			
		{
			if(student1.score<student2.score)
				printf("num=%d\nname=%s\nscore=%d\n",student2.num,student2.name,student2.score);
				else
				{
					printf("num=%d\nname=%s\nscore=%d\n",student1.num,student1.name,student1.score);
					printf("num=%d\nname=%s\nscore=%d\n",student2.num,student2.name,student2.score);
				}
		}
}
