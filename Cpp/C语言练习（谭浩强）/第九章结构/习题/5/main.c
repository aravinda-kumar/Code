#include <stdio.h>
struct student {
	int num;
	char name[30];
	float score[3];
	float ave;
};
void main()
{
	struct student stu[5];
	int i;
	for(i=0;i<5;i++)
	{
		scanf("%d %s %f %f %f",&stu[i].num,stu[i].name,&stu[i].score[0],&stu[i].score[1],&stu[i].score[2]);
		stu[i].ave=(stu[i].score[0]+stu[i].score[1]+stu[i].score[2])/3;
	}
	float a=stu[0].ave;
	int m=0;
	for(i=0;i<5;i++)
	{
		if(a<stu[i].ave)	m=i;
	}
	printf("%3d %5s %-3.1f %-3.1f %-3.1f %-4.2f",stu[m].num,stu[m].name,stu[m].score[0],stu[m].score[1],stu[m].score[2],stu[m].ave);
}
