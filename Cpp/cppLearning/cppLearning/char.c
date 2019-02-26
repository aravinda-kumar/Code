#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int main(void)
{
	char ch;

	while (1)
	{
		ch = _getch();
		printf("%c\n", ch);
		if (ch == 'q')	break;
	}
	

	system("pause");
	return 0;
}