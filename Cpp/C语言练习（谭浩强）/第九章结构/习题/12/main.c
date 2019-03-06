#include <stdio.h>
#include <stdlib.h>
struct student {
				int num;
				char name[20];
				char sex;
				int age;
				struct student *next;
};
void main()
{
	struct student *p1,*p2,*head;
	int i=0;
	int len;
	len=sizeof(struct student);
	p1=p2=(struct student *)malloc(len);
	scanf("%d %s %c %d",&p1->num,p1->name,&p1->sex,&p1->age);
	head=NULL;
	while(p1->num!=0)
	{
		i++;
		if(i==1)	head=p1;
		else
		{
			p2->next=p1;
			p2=p1;
		}
		p1=(struct student *)malloc(len);
		scanf("%d %s %c %d",&p1->num,p1->name,&p1->sex,&p1->age);
	}
	p2->next=NULL;
	printf("*************************************************\n");
	p1=head;
	while(p1!=NULL)
	{
		printf("%3d %5s %c %2d\n",p1->num,p1->name,p1->sex,p1->age);
		p1=p1->next;
	}
	printf("*************************************************\n");
	int n;
	printf("Please input the age you want to delete:");
	scanf("%d",&n);
	p1=head;
	while(p1!=NULL)
	{
		if(p1->age==n)	break;
		else p1=p1->next;
	}
	if(p1==head)
	{
		head=p1->next;
		p1->next=NULL;
		free(p1);
	}
	else
	{
		p2=head;
		if(p2->next==p1)
		{
			p2->next=p1->next;
			p1->next=NULL;
			free(p1);
		}
	}
	printf("*************************************************\n");
	p1=head;
	while(p1!=NULL)
	{
		printf("%3d %5s %c %2d\n",p1->num,p1->name,p1->sex,p1->age);
		p1=p1->next;
	}
}
