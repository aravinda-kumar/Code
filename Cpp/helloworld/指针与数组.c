//
// Created by shuncs on 19-2-21.
//

#include <stdio.h>

int main(void)
{
    int a[5] = {10,2,30,4,50};
    int * p;
    p = &a[0];
    //定义的指针是可以进行自加或者自减的
    //但是数组的首地址a是不可以的，a实际是一个常量，所以不可以被修改

    printf("%p, %p, %p, %p, %p\n", p, p+1, p+2, p+3, p+4);
    printf("%p, %p, %p, %p, %p\n", &a[0], &a[1], &a[2], &a[3], &a[4]);

    for(int i=0;i<5;i++)
    {
        //*的优先级高于+，所以要加括号。
        //后置自加的优先级高于*
        //printf("%d ", *(p+i));
        //printf("%d ", *p++);
        //指针也可以使用下标运算
        printf("%d ", p[i]);
    }
    printf("\n");

    return 0;
}