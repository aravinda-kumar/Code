#include <stdio.h>
void main()
{
	struct student{
					int num;
					char name[30];
					char sex;
					char add[30];
	}a={10101,"Limin",'M',"123 BeiJing Road"};
	printf("num=%d\nname=%s\nsex=%c\nadd=%s\n",a.num,a.name,a.sex,a.add);
}
