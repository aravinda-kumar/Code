#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

#define CATA(x, y) #x ## #y

int main(void)
{
	printf("%s\n", CATA(123, 456));
	

	system("pause");
	return 0;
}