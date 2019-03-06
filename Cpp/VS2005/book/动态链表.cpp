//#include <iostream>
//using namespace std;
//struct student {
//	int num;
//	float score;
//	struct student *next;
//};
//
//struct student *creat()
//{
//	struct student *p1,*p2,*head;
//	int i=0;
//	p1=p2=new student;
//	cin >> p1->num >> p1->score;
//	head=NULL;
//	i++;
//	while(p1->num!=0)
//	{
//		if(i==1)		head=p1;
//		else
//		{
//			p2->next=p1;
//			p2=p1;		
//			p1=new student;
//			cin >> p1->num >> p1->score;
//		}
//		i++;	
//	}
//	p2->next=NULL;
//	delete p1,p2;
//	return head; 
//}
//
//void print(struct student *head) 
//{			
//	struct student *p;
//	if(head!=NULL)
//	{
//		p=head;
//		while(p!=NULL)
//		{
//			cout << p->num << "  " << p->score;
//			p=p->next;
//			cout << endl;
//		}
//	}
//}
//
//void main()
//{	
//	print(creat());
//	system("pause");
//}
