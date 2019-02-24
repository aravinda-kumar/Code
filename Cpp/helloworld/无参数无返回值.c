//
// Created by shuncs on 19-2-24.
//

#include <stdio.h>

//C语言允许函数不写返回值，默认是int
//C++不允许
void fun(void)  //void可称为函数类型，也可成为返回值类型
{
    printf("function\n");
}

int main()
{
    //函数名称也可认为是一个变量
    fun();

    return 0;
}