#include <stdio.h>
#include <stdlib.h>
struct student {
			int num;
			float score;
			struct stuent *next;
}; 
int n=0;
void main()
{
	struct student *p1,*p2,*head;
	head=NULL;
	int len;
	len=sizeof(struct student);
	p1=p2=(struct student *)malloc(len);
	scanf("%d %f",&p1->num,&p1->score);
	while(p1->num!=0)
	{
		n++;
		if(n==1)	head=p1;
		else
		{
			p2->next=p1;
			p2=p1;
		}
		p1=(struct student *)malloc(len);
		scanf("%d %f",&p1->num,&p1->score);
	}
	p2->next=NULL;	
	printf("There is %d dots\n",n);
	p1=head;
	while(p1!=NULL)
	{
		printf("%d %-3.2f\n",p1->num,p1->score);
		p1=p1->next;
	}
	int i;
	printf("Please input the number of student you want to delete:");
	scanf("%d",&i);
	p1=head;
	while(p1!=NULL)
	{
		if(p1->num==i)	break;
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
		{
			p2=head;
			while(p2!=NULL)
			{
				if(p2->next==p1)	break;
				else p2=p2->next;
			}
			p2->next=p1->next;
			p1->next=NULL;
			free(p1);
		}
	}
	printf("*********************************************\n");
	p1=head;
		while(p1!=NULL)
	{
		printf("%d %-3.2f\n",p1->num,p1->score);
		p1=p1->next;
	}
	int m;
	p1=(struct student *)malloc(len);
	printf("*********************************************\n");
	printf("Please enter the number & score:");
	scanf("%d %f",&p1->num,&p1->score);
	printf("*********************************************\n");
	printf("Please input the location you want to put the dot(after one dot or No.1):");
	scanf("%d",&m);
	p2=head;
	while(p2!=NULL)
	{
		if(p2->num==m)	break;
		else p2=p2->next;
	}
	if(p2==NULL)
	{
		p1->next=head;
		head=p1;
	}
	else
	{
		p1->next=p2->next;
		p2->next=p1;
	}
		printf("*********************************************\n");
	p1=head;
	while(p1!=NULL)
	{
		printf("%d %-3.2f\n",p1->num,p1->score);
		p1=p1->next;
	}
}
