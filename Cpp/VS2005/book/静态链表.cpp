//#include <iostream>
//using namespace std;
//
//struct student
//{
//	int num;
//	int score;
//	struct student *next;
//};
//
//int main()
//{
//	student a,b,c,*p,*head;
//	a.num = 1001; a.score = 89;
//	b.num = 1002; b.score = 88;
//	c.num = 1003; c.score = 87;
//	head = &a;
//	a.next = &b;
//	b.next = &c;
//	c.next = NULL;
//	p = head;
//	while(p!=NULL)
//	{
//		cout  << p->num << "  " << p->score << endl;
//		p=p->next;
//	}
//	system("pause");
//	return 0;
//}