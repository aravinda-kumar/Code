////
//// Created by shuncs on 19-2-24.
////
//
//#include <stdio.h>
//#include <stdlib.h>
//#include <malloc.h>
//
//int main(void)
//{
//    int *p = (int*)malloc(sizeof(int));
//    *p = 12;
//    printf("%d\n", *p);
//    printf("%p\n", p);
//    //函数原型 void free(void *memblock)
//    //参数是void*表示一切指针皆可以传入，用来释放
//    free(p);
//    free(p);
//    //释放之后将p变成null，习惯操作
//    p = NULL;
//    //free后的指针，其空间不能再次使用
//    //free只是代表该空间可以被别操作系统再次使用，并没有将p中的地址值产生变化
//    //不能重复释放同一块内存空间
//    printf("%p\n", p);
//    //不允许释放栈区空间
//    //int a[3]={0};
//    //free(a);
//    //指针释放必须从头开始
//
//    return 0;
//}