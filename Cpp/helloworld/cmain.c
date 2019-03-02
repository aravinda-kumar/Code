////
//// Created by shuncs on 19-3-1.
////
//
//#include <stdio.h>
//#include "common2.h"
//
//static int c = 12;
//int *p;
//int b[3];
//
//struct Node
//{
//    int a;
//    double b;
//}node;
//
//void fun(void);
//extern void fun2(void);
//void fun3(void);
//
//int main(void)
//{
//    printf("%p\ta=%d\n", &a, a);
//    //a在c3中定义
//    printf("a=%d\n", a);
//    printf("%p\n", p);
//    printf("%d, %d, %d\n", b[0], b[1], b[2]);
//    printf("%d, %.2lf\n", node.a, node.b);
//
//    fun();
//    fun3();
//    fun2();
//
//
//    return 0;
//}
//
//void fun3(void)
//{
//    extern int a;
//    a = 45;
//    printf("%p\ta=%d\n", &a, a);
//}