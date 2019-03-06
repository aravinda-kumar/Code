#include <stdio.h>
#include <stdlib.h>
struct student {
					int num;
					float score;
					struct student *next;
};
struct student *creat()
{
	struct student *p1,*p2,*head;
	int i=0;
	int len;
	len=sizeof(struct student);
	p1=p2=(struct student *)malloc(len);
	scanf("%d %f",&p1->num,&p1->score);
	head=NULL;
	i++;
	while(p1->num!=0)
	{
		if(i==1)		head=p1;
		else
		{
			p2->next=p1;
			p2=p1;		
			p1=(struct student *) malloc(len);
			scanf("%d %f",&p1->num,&p1->score);			
		}
		i++;	
	}
	p2->next=NULL;
	return head; 
}
void print(struct student *head) 
{			
	struct student *p;
	if(head!=NULL)
	{
		p=head;
		while(p!=NULL)
		{
			printf("%5d %4.2f\n",p->num,p->score);
			p=p->next;
		}
	}
}
void main()
{	
	print(creat());
}
