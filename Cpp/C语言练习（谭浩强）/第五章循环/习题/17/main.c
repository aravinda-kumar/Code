#include <stdio.h>
void main()
{
	char i,j,k;				//i==A;j==B;k==C
	for(i='X';i<='Z';i++)
		for(j='X';j<='Z';j++)
			if(i!=j)
				for(k='X';k<='Z';k++)
					if(i!=k&&j!=k)
						if(k!='X'&&k!='Z'&&i!='X')
							printf("A==%c\tB==%c\tC==%c",i,j,k);
}
