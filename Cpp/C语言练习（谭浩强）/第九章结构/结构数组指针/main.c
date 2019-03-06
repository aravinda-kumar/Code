#include <stdio.h>
void main()
{
	struct student{
				int  num;
				char name[20];
				char sex;
				int  age;
	};
	struct student stu[3]={{10101,"liming",'M',18},{10102,"zhang fang",'M',19},{10104,"wang min",'F',20}};
	struct student *p;
	p=stu;
	int i;
	for(i=0;i<3;i++)
		printf("%5d%15s%2c%3d\n",(p+i)->num,(p+i)->name,(p+i)->sex,(p+i)->age);
}
