#include <stdio.h>
#include <stdlib.h>
struct student
{
	int num;
	float score;
	struct student *next;
};

struct student *creat()
{
	struct student *p1,*p2,*head;
	int len;int i;
	len=sizeof(struct student);
	p1=p2=(struct student *) malloc(len);
	scanf("%d %f",&p1->num,&p1->score);
	while(p1->num!=0)
	{
		i++;
		if(i==1) head=p1;
		else
		{
			p2->next=p1;
			p2=p1;
		}
		p1=(struct student *)malloc(len);
		scanf("%d %f",&p1->num,&p1->score);
	}
	p2->next=NULL;
	return head;
}

struct student *lianjie(struct student *a,struct student *b)
{
	struct student *p1,*head;
	p1=a;
	while(p1->next!=NULL)
		p1=p1->next;
	p1->next=b;
	head=a;
	return head;
}

struct student *paixu(struct student *p)
{
	struct student *p1,*p2,*head;
	p1=p;
	int n;
	n=p1->num;
	while(p1!=NULL)
	{	
		if(n>p1->num)
		{
			n=p1->num;
			p2=p1;
		}
		p1=p1->next;
	}
	head=p2;
}

void print(struct student *p)
{
	struct student *p1;
	p1=p;
	while(p1!=NULL)
	{
		printf("%3d %-3.2f  %d\n",p1->num,p1->score,p1->next);
		p1=p1->next;
	}
}
void main()
{	
	struct student *a,*b,*c;
	printf("Please input a:\n");
	a=creat();
	print(a);
	printf("*****************************************\n");
	printf("\n");
	printf("Please input b:\n");
	b=creat();
	print(b);
	printf("*****************************************\n");
	c=lianjie(a,b);
	print(c);
	printf("*****************************************\n");
	c=paixu(a);
	printf(c);
}
