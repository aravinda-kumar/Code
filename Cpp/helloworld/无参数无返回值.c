////
//// Created by shuncs on 19-2-24.
////
//
//#include <stdio.h>
//
////C语言允许函数不写返回值，默认是int
////C++不允许
////标准C语言规定，没有参数时，参数列表要写void
////C++没有这层意思，C++不写==void
////在C语言中不写表示参数个数不确定
//void fun(void)  //void可称为函数类型，也可成为返回值类型
//{
//    printf("function\n");
//}
//
//int main()
//{
//    //函数名称也可认为是一个变量
//    //没有参数的时候括号里面不用写内容，void也不用写
//    fun();
//    //函数调用的本质
//    //函数地址+参数列表
//    //函数的名字就是函数的地址
//    //对函数名字&即&fun, &fun == fun
//    printf("%p\n", fun);
//    printf("%p\n", &fun);
//
//    (&fun)();
//
//    void (*p)(void) = fun;
//    p();
//
//    return 0;
//}