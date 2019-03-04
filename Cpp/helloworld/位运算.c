////
//// Created by shuncs on 19-3-3.
////
//
//#include <stdio.h>
//
//union Un
//{
//    int a;
//    float f;
//};
//
//struct Bit
//{
//    int b8: 1;      //低位
//    int b7: 1;
//    int b6: 1;
//    int b5: 1;
//    int b4: 1;
//    int b3: 1;
//    int b2: 1;
//    int b1: 1;      //高位
//};
//
//int main(void)
//{
//    char a = -123;
//    char b = ~a;
//    printf("a=%d\n", a);
//    printf("b=%d\n", b);
//
//    union Un un1 = {.f = 0.5};
//    union Un un2 = {.f = 0.8};
//    printf("%d\n", un1.a ^ un2.a);
//
//    float f1 = 0.5;
//    float f2 = 0.8;
//    int *p1 = (int *)&f1;
//    int *p2 = (int *)&f2;
//
//    int a1 = *p1;
//    int a2 = *p2;
//    printf("%d\n", a1 ^a2);
//
//    int c = -44;
//    c >>= 2;
//    printf("%d\n", c);
//
//    struct Bit bit;
//    bit.b1 = 1;
//    bit.b2 = 1;
//    bit.b3 = 1;
//    bit.b4 = 1;
//    bit.b5 = 1;
//    bit.b6 = 1;
//    bit.b7 = 1;
//    bit.b8 = 1;
//    printf("%d\b", bit);
//
//    return 0;
//}