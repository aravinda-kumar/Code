//
// Created by zhushuai on 19-2-15.
//


#include <stdio.h>

int main(void)
{
    float f = 1213.45;
    double d = 12.123;
    long double ld = 11.22;

    printf("%f, %lf, %lf\n", f, d, ld);

    //%e科学计数法
    printf("%e, %e\n", 0, 0.0);

    //out: 0.000000e+00, 7.063274e-304
    //小数格式-m.nf，总共m位，n位小数，负号的作用是实现数据的左对齐；
    printf("%5.2f\n", f);
    scanf("%lf", &d);
    printf("%lf", d);

    //在输出格式化中float, double, long double 都可以以%f转义输出
    //在输入格式化中float, double, long double 必须和%f, %lf, %lf 一一对应

    return 0;
}