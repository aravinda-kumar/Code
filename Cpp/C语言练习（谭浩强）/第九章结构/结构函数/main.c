#include <stdio.h>
struct student {
					int num;
					char name[20];
					float score[3];
					float ave;	
};
void input(struct student *p);
int max(struct student *p);
void output(struct student *p,int n); 
void main()
{
	struct student stu[3];
	struct student *p;
	p=stu;
	input(p); 
	output(p,max(p));
}
void input(struct student *p)
{	
	int i;
	for(i=0;i<3;i++)		
	{
	//	scanf("%d %s %f %f %f",&(*(p+i)).num,&(*(p+i)).name,&(*(p+i)).score[0],&(*(p+i)).score[1],&(*(p+i)).score[2]);
		scanf("%d %s %f %f %f",&(p+i)->num,&(p+i)->name,&(p+i)->score[0],&(p+i)->score[1],&(p+i)->score[2]);
		(*(p+i)).ave=((*(p+i)).score[0]+(*(p+i)).score[1]+(*(p+i)).score[2])/3;
	}
}
int max(struct student *p)
{
	int m;
	int i;
	float t=p->ave;
	for(i=0;i<3;i++)
	{
		if(t<=(p+i)->ave)
			m=i;
	}
	return m;
}
void output(struct student *p,int n)
{
	printf("%d %5s %3.2f %3.2f %3.2f %3.2f\n",&(p+n)->num,(p+n)->name,(p+n)->score[0],(p+n)->score[1],(p+n)->score[2],(p+n)->ave);
}
