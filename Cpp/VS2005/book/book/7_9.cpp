//#include <iostream>
//using namespace std;
//
//struct Student
//{
//	int num;
//	int score;
//	Student *next;
//};
//
//Student *creat_chain();
//void show_chain(Student *p);
//Student *del_chain(Student *p, int num);
//Student *insert_chain(Student *p, Student *ps);
//
//int main()
//{
//	Student *p,*p1,*p2;
//	Student stu={1006,100};
//	p1=&stu;
//	p=creat_chain();
//	show_chain(p);
//	cout << "******************" << endl;
//	show_chain(del_chain(p, 1003));
//	cout << "******************" << endl;
//	p2=insert_chain(p, p1);
//	show_chain(p2);
//	system("pause");
//	return 0;
//}
//
//Student *creat_chain()
//{
//	Student *head,*p1,*p2;
//	int n=0;
//	head = NULL; 
//	p1 = p2 = new Student;
//	cin >> p1->num >> p1->score;
//	while (p1->num!=0 && p1->score!=0)
//	{	
//		n++;
//		if(n==1) head=p1;
//		else	p2->next=p1;	
//		p2=p1;
//		p1=new Student;
//		cin >> p1->num >> p1->score;
//	}
//	p2->next=NULL;
//	return head;
//}
//void show_chain(Student *p)
//{
//	while(p!= NULL)
//	{
//		cout << p->num << ' ' << p->score << endl;
//		p=p->next;
//	}
//}
//
//Student *del_chain(Student *p, int num)
//{
//	Student *head,*p1;
//	head = p1 = p;
//	while(p->next != NULL)
//	{
//		if(p->num == num)
//			break;
//		else
//		{
//			cout << "&&&&&&&&&&&&&&&&&&" << endl;
//			p1=p;
//			p=p->next;
//		}
//	}
//	if(p==head)
//		head = head->next;
//	else
//	{
//		if(p->next==NULL)
//		{
//			p1->next=NULL;
//		}
//		else
//		{
//			p1->next=p->next;
//		}
//	}
//
//	return head;
//}
//
//Student *insert_chain(Student *p, Student *ps)
//{
//	Student *head, *p1;
//	head=p1=p;
//	while(p->next != NULL)
//	{
//		if(ps->num<p->num)
//			break;
//		else
//		{
//			p1=p;
//			p=p->next;
//		}
//	}
//	if(p==head)
//	{
//		head=ps;
//		ps->next=p1;
//	}
//	else
//	{
//		if(p->next==NULL)
//		{
//			p->	next=ps;
//			ps->next=NULL;
//		}
//		else
//		{
//			p1->next=ps;
//			ps->next=p;
//		}
//	}
//	return head;
//}