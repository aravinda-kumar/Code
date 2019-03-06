#include <stdio.h>
#include <string.h>
void main()
{
	struct Student {
						int   num;
						char  name[30];
						char  sex;
						float score;
	};
	struct Student student1;	
	struct Student *pt;
	pt=&student1;
	student1.num=10101;
	strcpy(student1.name,"li ming");
	student1.sex='M';
	student1.score=89.5;
	printf("%5d %s  %c  %-3.1f",student1.num,student1.name,student1.sex,student1.score);
	printf("\n");
	printf("%5d %s  %c  %-3.1f",(*pt).num,(*pt).name,(*pt).sex,pt->score);	
}
