////
//// Created by shuncs on 19-2-24.
////
//
//#include <stdio.h>
//#include <stdlib.h>
//#include <malloc.h>
//#include <string.h>
//
//int main(void)
//{
//
//    //malloc 在堆区申请指定大小的连续的一段空间，并返回该空间的首地址
//    //函数原型
//    //void * malloc(size_t size)
//    //size_t size 是一个整形表达式
//    //size_t == unsigned int
////    //参数直接写数字的时候可以加后缀u表示无符号数
////    int *p = (int*)malloc(sizeof(int));
////    //申请的空间不可以进行初始化，需要进行手动赋值
////    *p = 4;
////    printf("%d\n", *p);
////    free(p);
////
////    //malloc申请空间正常
////    //malloc(0)
////    int *p1 = (int*)malloc(0);
////    //可以返回对应的地址，但是这一块内存区域不可用
////    //malloc(极限)
////    //申请失败会返回NULL或者0
////    int *p2 = (int*)malloc(4*1024*1024*1024l);
////    printf("%p\n", p2);
////    //使用指针前，先判断指针是否是null，不然程序会直接崩溃
////    if (NULL == p2)
////    {
////        printf("空间申请失败");
////        return -1;
////    }
////    *p2 = 12;
//    //强制类型转换
//    //malloc返回的是void*，我们可以将其转换成我们想要的类型
//
//    //分配一个内存空间，返回的指针是指向一个含有4个int元素的数组
//    int (*pt)[4] = (int(*)[4])malloc(sizeof(int(*)[4]));
//    for(int i=0;i<4;i++)
//    {
//        *(*pt+i) = i;
//    }
//    for(int i=0;i<4;i++)
//    {
//        printf("%d\t", (*pt)[i]);
//    }
//    printf("\n");
//
//    //memset
//    int *p = (int*)malloc(sizeof(int)*10);
//    //memset是按照字节赋值，不是按照变量类型赋值
//    //int由4个字节，所以有区别
//    memset(p, 0, sizeof(int)*10);
//    for(int i=0;i<10;i++)
//    {
//        printf("%d\t", p[i]);
//    }
//    printf("\n");
//
//    return 0;
//}