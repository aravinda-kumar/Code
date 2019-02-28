////
//// Created by shuncs on 19-2-28.
////
//
//#include <stdio.h>
//
//int main(void)
//{
//    //每一个元素指向一个常量字符串
//    //实质上是一个指针数组
//    char *ch[3] = {"123", "ssdddd", "adsdfdfsdsd"};
//    //字符串数组直接指向字符常量区的内容
//    for(int i=0;i<3;i++)
//    {
//        printf("%s\n", ch[i]);
//    }
//
//    //常量字符串指针可以更改指向，但是不能修改字符串的内容
//    ch[1] = "zhushuai";
//
//    for(int i=0;i<3;i++)
//    {
//        printf("%s\n", ch[i]);
//    }
//    printf("=================\n");
//
//    //二维字符数组
//    char str[2][4] = {"zhu", "123"};
//    //将字符常量去的常量字符串复制到栈区
//    //后续通过数组操作的是栈区的内容
//    for(int i=0;i<2;i++)
//    {
//        printf("%s\n", str[i]);
//    }
//
//
//    return 0;
//}