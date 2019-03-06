#include <stdio.h>
#include <stdlib.h>
struct student {
	char name[10];
	int num;
	int age;
	char addr[15];
};
void main()
{
	struct student stu[10];
	FILE *fp;
	int i;
	for(i=0;i<10;i++)
		scanf("%s %d %d %s",stu[i].name,&stu[i].num,&stu[i].age,stu[i].addr);
	if((fp=fopen("file.txt","wb"))==NULL)
	{
		printf("error");
		exit (0);
	}
	for(i=0;i<10;i++)
		fwrite(&stu[i],sizeof(struct student),1,fp);
	fclose(fp);

}
