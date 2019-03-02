#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

#define CATA(x, y) #x ## #y

int main(int argc, char* argv[])
{
	for (int i = 0; i < argc; i++)
	{
		printf("%s\n", argv[i]);
	}
	

	system("pause");
	return 0;
}