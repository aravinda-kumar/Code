//
// Created by zhushuai on 19-2-18.
//

#include <stdio.h>

int main(void)
{
    //用goto实现循环结构
    int nCount=0;
    step:
    printf("hello world!\n");
    nCount++;
    if(nCount == 3)
    {
        goto next;
    }
    goto step;

    next:
    printf("terminate");

    //break和goto
    //break一般只能跳出一层循环
    //每一层使用相同条件的break可以逐层跳出所有循环
    //goto可以直接跳出所有循环
    //这也是goto可以使用的唯一一种情况
    //一般情况下不允许使用goto

    return 0;
}