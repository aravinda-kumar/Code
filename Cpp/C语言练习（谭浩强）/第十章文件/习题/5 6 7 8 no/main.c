#include <stdio.h>
#include <stdlib.h>
struct student {
	int num;
	char name[10];
	float score[3];
	float aver;
};
void main()
{
	struct student stu[6];
	struct student temp;
	struct student st;
	FILE *fp,*fp1,*fp2;
	if((fp=fopen("student.txt","wb"))==NULL)
	{
		printf("error!");
		exit(0);
	}
	if((fp1=fopen("student1.txt","rb"))==NULL)
	{
		printf("error!");
		exit(0);
	}
	if((fp2=fopen("studentsort.txt","wb"))==NULL)
	{
		printf("error!");
		exit(0);
	}
	int i,j;
	for(i=0;i<5;i++)
	{
		scanf("%d %s %f %f %f",&stu[i].num,stu[i].name,&stu[i].score[0],&stu[i].score[1],&stu[i].score[2]);
		stu[i].aver=(stu[i].score[0]+stu[i].score[1]+stu[i].score[2])/3;
	}
	for(i=0;i<5;i++)
		fwrite(&stu[i],sizeof(struct student),1,fp);
	for(i=0;i<5;i++)
		fread(&stu[i],sizeof(struct student),1,fp1);
	printf("*************************************************\n");
	for(i=0;i<5;i++)
		printf("%3d %2s %4.2f %4.2f %4.2f %4.2f\n",stu[i].num,stu[i].name,stu[i].score[0],stu[i].score[1],stu[i].score[2],stu[i].aver);
	for(i=0;i<4;i++)
	{
		for(j=0;j<4-i;j++)
		{
			if(stu[j].aver<stu[j+1].aver)
			{
				temp=stu[j];stu[j]=stu[j+1];stu[j+1]=temp;
			}
		}
	}
	printf("***************Ö±½ÓÊä³ö*******************\n");
	for(i=0;i<5;i++)
		printf("%3d %2s %4.2f %4.2f %4.2f %4.2f\n",stu[i].num,stu[i].name,stu[i].score[0],stu[i].score[1],stu[i].score[2],stu[i].aver);
	for(i=0;i<5;i++)
		fwrite(&stu[i],sizeof(struct student),1,fp2);
	fclose(fp);
	fclose(fp1);
	fclose(fp2);
	printf("**************INSERT NEW ONE*****************\n");
	scanf("%d %s %f %f %f",&st.num,st.name,&st.score[0],&st.score[1],&st.score[2]);
	st.aver=(st.score[0]+st.score[1]+st.score[2])/3;
//		for(j=0;j<5;j++)
//		{
//			if(stu[5].aver<stu[j].aver)
//			{
//				temp=stu[5];stu[5]=stu[j];stu[j]=temp;
//				break;
//			}
//		}
	if((fp2=fopen("studentsort.txt","ab"))==NULL)
	{
		printf("error!");
		exit(0);
	}
	printf("*************************************************\n");
//	for(i=0;i<6;i++)
		fseek(fp2,0,2);
		fwrite(&st,sizeof(struct student),1,fp2);
}
