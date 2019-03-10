#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<stdlib.h>
#include<string.h>

int main(void)
{
	char ch[20] = "zhu";
	char ch2 = 'a';
	strcat(ch, &ch2);

	printf("%s\n", ch);

	system("pause");
	return 0;
}