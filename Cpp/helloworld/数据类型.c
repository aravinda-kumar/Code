////
//// Created by zhushuai on 19-2-14.
////
//
//#include <stdio.h>
//#include <stdlib.h>
//
//int main(void)
//{
//    //%d格式化输出符号
//    //或者叫转义字符
//    //以十进制整数形式输出数据
//    printf("输出的结果=%d\n", 12);
//
//    //十进制的转义字符是%d
//    //八进制的转义字符十%o
//    //十六进制的转义字符十%x或者%X
//    printf("10进制：%d, 8进制:%o, 16进制: %X\n", 122, 122, 122);
//
//    //申明一个int类型变量就是申明一个存储类型数据的容器
//    //这个容器可以放置任何int类型数据
//    int a = 123456;
//    printf("%d\n", a);
//
//    //左值：变量    右值：常量
//
//    //有符号数 signed int
//    //无符号数 unsigned int
//    int b = sizeof(a);
//    int c = sizeof(int);
//
//    printf("%d\n", b);
//    printf("%d\n", c);
//
//    //无符号数字的输出使用的是%u
//    unsigned int d = 31474836;
//    printf("%u\n", d);
//    int dsize = sizeof(unsigned int);
//    printf("%d\n", dsize);
//
//    //short的输出转义字符是%hd
//    short e = 129;
//    printf("short:%d\n", sizeof(short));
//    printf("%hd\n", e);
//
//    //long的输出转义字符是%ld
//    long f = 1111111;
//    printf("long:%d\n", sizeof(long));
//    printf("%ld\n", f);
//
//    //long long
//    long long g = 12343545667788;
//    printf("long long:%d\n", sizeof(long long));
//    printf("%lld\n", g);
//    return 0;
//}