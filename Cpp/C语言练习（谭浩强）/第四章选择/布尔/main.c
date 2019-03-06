#include <stdio.h>
#include <stdbool.h>
void main()
{
	float score;
	scanf("%f",&score);
	bool a,b;
	a=score>=60;
	b=score<=69;
	if(a==true&&b==true)
		printf("The grade is 'C'!");
}
