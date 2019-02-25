////
//// Created by shuncs on 19-2-25.
////
//
//#include <stdio.h>
//
//int i=0;
//
//void fun(int num)
//{
//    //递归本身就有循环的意味
//    if(num >= 1)
//    {
//        printf("%d ", num);
//        fun(num-1);
//        //printf("%d ", num);
//        //当printf放到后面，输出就是1,2,3,4,5
//        //用递归展开来理解
//    }
//}
//
//int fun1(int n)
//{
//    if(2 == n || 1 == n)
//    {
//        return 1;
//    }
//    return fun1(n-2)+fun1(n-1);
//}
//
//int fun2(int n)
//{
//    if(1 == n)
//        return 1;
//    return n*fun2(n-1);
//}
//
//int main(void)
//{
//    fun(5);
//    printf("\n");
//
//    for(int i=1;i<10;i++)
//        printf("%d\t", fun1(i));
//    printf("\n");
//
//    return 0;
//}