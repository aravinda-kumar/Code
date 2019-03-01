////
//// Created by shuncs on 19-3-1.
////
//
//#include <stdio.h>
//
////myint == int
//typedef int myint;
////myint2 == myint == int
//typedef myint myint2;
//
////unsigned int == uint
//typedef unsigned int uint;
//
//typedef int* pint;
//
//typedef struct
//{
//    int x;
//}_Node;
//
//void fun(int a, double d);
//
//typedef void (*pFun)(int a, double d);
//
//int main(void)
//{
//    myint a;
//    a = 12;
//    printf("%d\n", a);
//
//    pint p = &a;
//    printf("%d\n", *p);
//
//    _Node node = {12};
//    printf("%d\n", node.x);
//
//    pFun pt = fun;
//    pt(12, 12.34);
//
//    return 0;
//}
//
//void fun(int a, double d)
//{
//    printf("%d, %.2lf\n", a,d);
//}