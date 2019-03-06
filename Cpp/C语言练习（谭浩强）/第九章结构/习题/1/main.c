#include <stdio.h>
struct Date{
		int year;
		int month;
		int day;
}today={2016,12,31};
void main()
{
	int i;
	if(((today.year%4==0)&&(today.year%100!=0))||(today.year%400==0))
	{
		if(today.month==1)
			printf("Today is No.%d day in this year.",today.day);
		if(today.month==2)
			printf("Today is No.%d day in this year.",today.day+31);
		if(today.month==3)
			printf("Today is No.%d day in this year.",today.day+31+29);
		if(today.month==4)
			printf("Today is No.%d day in this year.",today.day+31+29+31);
		if(today.month==5)
			printf("Today is No.%d day in this year.",today.day+31+29+31+30);
		if(today.month==6)
			printf("Today is No.%d day in this year.",today.day+31+29+31+30+31);
		if(today.month==7)
			printf("Today is No.%d day in this year.",today.day+31+29+31+30+31+30);
		if(today.month==8)
			printf("Today is No.%d day in this year.",today.day+31+29+31+30+31+30+31);
		if(today.month==9)
			printf("Today is No.%d day in this year.",today.day+31+29+31+30+31+30+31+31);
		if(today.month==10)
			printf("Today is No.%d day in this year.",today.day+31+29+31+30+31+30+31+31+30);
		if(today.month==11)
			printf("Today is No.%d day in this year.",today.day+31+29+31+30+31+30+31+31+30+31);
		if(today.month==12)
			printf("Today is No.%d day in this year.",today.day+31+29+31+30+31+30+31+31+30+31+30);
	}
	else
	{
		if(today.month==1)
			printf("Today is No.%d day in this year.",today.day);
		if(today.month==2)
			printf("Today is No.%d day in this year.",today.day+31);
		if(today.month==3)
			printf("Today is No.%d day in this year.",today.day+31+28);
		if(today.month==4)
			printf("Today is No.%d day in this year.",today.day+31+28+31);
		if(today.month==5)
			printf("Today is No.%d day in this year.",today.day+31+28+31+30);
		if(today.month==6)
			printf("Today is No.%d day in this year.",today.day+31+28+31+30+31);
		if(today.month==7)
			printf("Today is No.%d day in this year.",today.day+31+28+31+30+31+30);
		if(today.month==8)
			printf("Today is No.%d day in this year.",today.day+31+28+31+30+31+30+31);
		if(today.month==9)
			printf("Today is No.%d day in this year.",today.day+31+28+31+30+31+30+31+31);
		if(today.month==10)
			printf("Today is No.%d day in this year.",today.day+31+28+31+30+31+30+31+31+30);
		if(today.month==11)
			printf("Today is No.%d day in this year.",today.day+31+28+31+30+31+30+31+31+30+31);
		if(today.month==12)
			printf("Today is No.%d day in this year.",today.day+31+28+31+30+31+30+31+31+30+31+30);
	}
}
