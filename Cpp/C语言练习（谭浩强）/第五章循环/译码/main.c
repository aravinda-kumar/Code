#include <stdio.h>
#include <stdlib.h>
void main()
{
	char ch;
//	ch=getchar();
	while((ch=getchar())!='\n')                                //(ch=getchar())
	{
		if((ch>='a'&&ch<='z')||(ch>='A'&&ch<='Z'))
		{
			if((ch>='w'&&ch<='z')||(ch>='W'&&ch<='Z'))        //假设26字母为1~26  w位23  按照题目要求以w加4后变成a则23变成1即23-22 
				ch=ch-22;
			else
				ch=ch+4;
		}
		printf("%c",ch);
//		ch=getchar();
	}

}
