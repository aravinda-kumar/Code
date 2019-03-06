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
	long i;
	FILE *fp;
	if((fp=fopen("file.txt","rb"))==NULL)
	{
		printf("error!");
		exit(0);
	}
	for(i=0;i<10;i=i+2)
	{	
		fseek(fp,i*sizeof(struct student),0);
		fread(&stu[i],sizeof(struct student),1,fp);
		printf("%5s %4d %4d %7s\n",stu[i].name,stu[i].num,stu[i].age,stu[i].addr);
	}
	fclose(fp);
}
