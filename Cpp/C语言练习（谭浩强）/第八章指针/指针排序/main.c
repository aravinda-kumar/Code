#include <stdio.h>
void swap(int *p1,int*p2);
void exchange(int *p1,int *p2,int *p3);
void main()
{
	int a,b,c;
	int *pa,*pb,*pc;
	printf("Please input three integer numbers:");
	scanf("%d %d %d",&a,&b,&c);
	pa=&a;pb=&b;pc=&c;
	exchange(pa,pb,pc);
	printf("The sorted numbers are:");
	printf("%d\t%d\t%d",a,b,c);
}
void swap(int *p1,int*p2)
{
	int temp;
	if(*p1>*p2)
	{
		temp=*p1;*p1=*p2;*p2=temp;
	}
}
void exchange(int *p1,int *p2,int *p3)
{
	swap(p1,p2);	
	swap(p1,p3);	
	swap(p2,p3);		
}

/////////////////////////////////////////////
/***************other way*******************/
/////////////////////////////////////////////
//#include <stdio.h>
//void swap(int *p1,int*p2);
//void exchange(int *p1,int *p2,int *p3);
//void main()
//{
//	int a,b,c;
//	int *pa,*pb,*pc;
//	printf("Please input three integer numbers:");
//	scanf("%d %d %d",&a,&b,&c);
//	pa=&a;pb=&b;pc=&c;
//	exchange(pa,pb,pc);
//	printf("The sorted numbers are:");
//	printf("%d\t%d\t%d",a,b,c);
//}
//void swap(int *p1,int*p2)
//{
//	int temp;
//		temp=*p1;
//		*p1=*p2;
//		*p2=temp;
//}
//void exchange(int *p1,int *p2,int *p3)
//{
//	if(*p1>*p2)	swap(p1,p2);	
//	if(*p1>*p3)	swap(p1,p3);	
//	if(*p2>*p3)	swap(p2,p3);		
//}
