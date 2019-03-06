#include <stdio.h>
void main()
{
	char str[10]={'B','G','0','6','9','a','7','b','9',','};
	int i;
	for(i=0;i<10;i++)
	{
		if(str[i]>='A'&&str[i]<='Z')	
			str[i]=90-str[i]+65;
		if(str[i]>='a'&&str[i]<='z')
			str[i]=122-str[i]+97;			
	}
	for(i=0;i<10;i++)
		printf("%c\t",str[i]);
}
