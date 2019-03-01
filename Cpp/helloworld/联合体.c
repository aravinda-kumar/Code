////
//// Created by shuncs on 19-3-1.
////
//
//#include <stdio.h>
//
////所有的成员共享一块内存
//union Un
//{
//    //联合体可以使成员变量按占用字节的从大到小排列
//    int i;
//    char c;
//    short s;
//
//}un1, un2;
//
//int main(void)
//{
//    printf("%p\n%p\n%p\n", &(un1.c), &(un1.s), &(un1.i));
//    //0x55f6e2daf014
//    //0x55f6e2daf014
//    //0x55f6e2daf014
//    //由结果可知，三个成员的首地址一样
//
//    //由于联合体公用一块内存，所以给占用空间最大的变量初始化即可
//    union Un un3 = {21};
//    printf("c=%c\ts=%d\ti=%d\n", un3.c, un3.s, un3.i);
//    return 0;
//}