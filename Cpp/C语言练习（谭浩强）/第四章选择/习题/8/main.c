#include <stdio.h>
void main()
{
	char ch;
	printf("Please input your Grade:");
	scanf("%c",&ch);
	printf("Your score is:");	
	switch(ch)
	{
		case 'A' :printf("90~100");break;
		case 'B' :printf("80~89");break;
		case 'C' :printf("70~79");break;
		case 'D' :printf("60~69");break;
		case 'E' :printf("0~60");break;
		default:printf("ERROR!");
	}
}
