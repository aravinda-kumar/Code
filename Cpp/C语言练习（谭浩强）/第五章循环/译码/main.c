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
			if((ch>='w'&&ch<='z')||(ch>='W'&&ch<='Z'))        //����26��ĸΪ1~26  wλ23  ������ĿҪ����w��4����a��23���1��23-22 
				ch=ch-22;
			else
				ch=ch+4;
		}
		printf("%c",ch);
//		ch=getchar();
	}

}
