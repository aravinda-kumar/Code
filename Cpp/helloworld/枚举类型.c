////
//// Created by shuncs on 19-3-1.
////
//
//#include <stdio.h>
//
////枚举的本质：一组有名字的int常数
////枚举使用的时候不需要声明变量之类的
//enum Color
//{
//    //这些名字是常量，不是变量，所以他们的值不可以发生变化
//    //枚举中的名字具有唯一性，且是全局唯一，别的枚举中也不能使用该名称
//    enum_Red,
//    enum_Black,
//    enum_White=21,
//    enum_Blue,
//    enum_Yellow=50
//};
//
//
//int main(void)
//{
//    printf("%d, %d, %d, %d, %d\n",enum_Red,enum_Black,enum_White,enum_Blue,enum_Yellow);
//    //等价于int = ...p
//    enum Color color = enum_Black;
//    int co = enum_Black;
//    printf("%d\n", color);
//
//    //enum的本质就是int，所以占用空间就是4字节
//    printf("%lu\n", sizeof(enum Color));
//
//    return 0;
//}