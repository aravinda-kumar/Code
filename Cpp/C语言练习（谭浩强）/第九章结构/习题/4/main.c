#include <stdio.h>
struct student {
	int num;
	char name[30];
	float score[3];
};
void print(struct student *p);
void input(struct student *p);
void main()
{
	struct student stu[5];
	struct student *p;
	p=stu;
	input(p);
	print(p);
}
void print(struct student *p)
{
	int i;
	for(i=0;i<5;i++)
		printf("%3d %5s %-3.2f %-3.2f %-3.2f\n",(p+i)->num,(p+i)->name,(p+i)->score[0],(p+i)->score[1],(p+i)->score[2]);
}
void input(struct student *p)
{
	int i;
	for(i=0;i<5;i++)
		scanf("%d %s %f %f %f",&(p+i)->num,(p+i)->name,&(p+i)->score[0],&(p+i)->score[1],&(p+i)->score[2]);
}

