//
// Created by shuncs on 19-2-25.
//

#include <stdio.h>
#include <zconf.h>

//参数个数不确定
//第一个参数必须定义
//第一个参数的作用，指定未知参数的个数
void fun(int a,...)
{
    //定义参数数组
    va_list ap;
    //将参数装进数组
    va_start(ap, a);
    printf("%d\n", va_arg(ap, int));
    printf("%.2lf\n", va_arg(ap, double));
    printf("%d\n", va_arg(ap, int));
}

int main(void)
{
    fun(3, 12, 34.34, 56);

    return 0;
}