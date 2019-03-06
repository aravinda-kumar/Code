#include <stdio.h>
void main()
{
	struct student {
						int num;
						char name[30];
						float score;
	};
	struct student stu[5]={10101,"zhang",78,10103,"wang",98.5,10106,"li",86,10108,"ling",73.5,10110,"sun",100};
	int i,j;
	struct student a;
	for(i=0;i<4;i++)
	{
		for(j=0;j<4-1;j++)
		{
			if(stu[j].score>stu[j+1].score)
			{
				a=stu[j];stu[j]=stu[j+1];stu[j+1]=a;
			}
		}
	}
	for(i=0;i<5;i++)
		printf("%5d%8s%6.2f\n",stu[i].num,stu[i].name,stu[i].score);
}
