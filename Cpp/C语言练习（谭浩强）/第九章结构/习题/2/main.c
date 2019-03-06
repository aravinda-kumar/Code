#include <stdio.h>
struct Date{
		int year;
		int month;
		int day;
};
int count(struct Date *p)
{
	int m;
	if(((p->year%4==0)&&(p->year%100!=0))||(p->year%400==0))
	{
		if(p->month==1)		m=p->day;
		if(p->month==2)		m=p->day+31;
		if(p->month==3)		m=p->day+31+29;
		if(p->month==4)		m=p->day+31+29+31;
		if(p->month==5)		m=p->day+31+29+31+30;
		if(p->month==6)		m=p->day+31+29+31+30+31;
		if(p->month==7)		m=p->day+31+29+31+30+31+30;
		if(p->month==8)		m=p->day+31+29+31+30+31+30+31;
		if(p->month==9)		m=p->day+31+29+31+30+31+30+31+31;
		if(p->month==10)	m=p->day+31+29+31+30+31+30+31+31+30;
		if(p->month==11)	m=p->day+31+29+31+30+31+30+31+31+30+31;
		if(p->month==12)	m=p->day+31+29+31+30+31+30+31+31+30+31+30;
	}
	else
	{
		if(p->month==1)		m=p->day;
		if(p->month==2)		m=p->day+31;
		if(p->month==3)		m=p->day+31+28;
		if(p->month==4)		m=p->day+31+28+31;
		if(p->month==5)		m=p->day+31+28+31+30;
		if(p->month==6)		m=p->day+31+28+31+30+31;
		if(p->month==7)		m=p->day+31+28+31+30+31+30;
		if(p->month==8)		m=p->day+31+28+31+30+31+30+31;
		if(p->month==9)		m=p->day+31+28+31+30+31+30+31+31;
		if(p->month==10)	m=p->day+31+28+31+30+31+30+31+31+30;
		if(p->month==11)	m=p->day+31+28+31+30+31+30+31+31+30+31;
		if(p->month==12)	m=p->day+31+28+31+30+31+30+31+31+30+31+30;
	}
	return m;
}
void main()
{	
	int m;
	struct Date *p;
	struct Date today={2016,12,31};
	p=&today;
	m=count(p);
	printf("Today is No.%d day in this year.",m);
}
