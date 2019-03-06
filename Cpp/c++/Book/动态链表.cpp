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
//int main()
//{
//	Student *head, *p1, *p2;
//	head = p1 = p2 =new Student;
//	cin >> p1->num >> p1->score;
//	while(p1->num!=0 && p1->score!=0)
//	{
//		p2 = p1;
//		p1=new Student;
//		p2->next=p1;
//		cin >> p1->num >> p1->score;
//	}
//	p2->next=NULL;
//	
//	p1=head;
//	while(p1!=NULL)
//	{
//		cout << p1->num << ' ' << p1->score << endl;
//		p1=p1->next;
//	}
//
//	system("pause");
//	return 0;
//}