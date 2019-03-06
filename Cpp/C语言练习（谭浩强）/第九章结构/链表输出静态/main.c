#include <stdio.h>
struct student {
				int num;
				float score;
				struct student *next;
};
void main()
{
	struct student a,b,c,*p,*head;
	a.num=10101;a.score=89.5;
	b.num=10103;b.score=90;
	c.num=10107;c.score=89;
	head=&a;
	a.next=&b;
	b.next=&c;
	c.next=NULL;
	p=head;
	while(p!=NULL)
	{
		printf("%5d %-3.2f\n",p->num,p->score);
		p=p->next ;
	}
}
