//
// Created by shuncs on 19-3-2.
//

#include <stdio.h>

int main(int agrc, char* argv[])
{
    for(int i=0;i<agrc;i++)
    {
        printf("%s\n", argv[i]);
    }

    return 0;
}