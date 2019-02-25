////
//// Created by shuncs on 19-2-25.
////
//
//#include <stdio.h>
//#include <stdlib.h>
//#include <malloc.h>
//
//void fun1(void)
//{
//    printf("this is a void function!\n");
//}
//
//int fun2(void)
//{
//    printf("this is a int function!\n");
//    //出现return函数就结束
//    //终止所在函数的执行，并返回指定数据
//    //在void函数中可以用return;终止函数
//    return 4;
//}
//
////return一次只能返回一个值
////可以是一段连续空间的首地址，这段地址里装着多个值，也就是返回一个数组的首地址
//int* fun3(void)
//{
//    //malloc是动态内存分配
//    //malloc的内存不会被自动销毁
//    int *p = (int*)malloc(sizeof(int)*2);
//    p[0] = 12;
//    p[1] = 15;
//    //数组只存在于当前代码块，超出此范围数组就被销毁
//    //int a[2] = {11,21};
//    return p;
//}
//
//int main(void)
//{
//    fun1();
//    printf("fun2 = %d\n", fun2());
//    printf("=================\n");
//    int *p = fun3();
//    printf("%d, %d\n", p[0], p[1]);
//    free(p);
//
//    return 0;
//}