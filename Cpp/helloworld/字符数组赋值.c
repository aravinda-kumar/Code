////
//// Created by shuncs on 19-2-28.
////
//
//#include <stdio.h>
//#include <string.h>
//
//int main(void)
//{
//    char str[10] = "hello";
//    char *p = "hello JZS";
//
//    printf("%s\n", p);
//
//    int i = 0;
//    for(; *p!='\0'; p++)
//    {
//        str[i++] = *p;
//    }
//    str[i] = '\0';
//
//    //由于指针p的指向已经发生了变化，所以在此无法打印原来的数据
//    //printf("%s\n", p);
//    //数组名称虽然是一个地址，但是不可以进行自加或者自减类的运算
//
//    printf("=============\n");
//    printf("%s\n", str);
//
//    //字符串复制函数 --- strcpy
//    //char *strcpy(char *strDestination, const char *strSource)
//    //第一个位置只能是字符数组，第二个位置可以使常量字符串或者字符数组
//    //返回值是修改后的strDestination
//    //strDestination的空间要能够容纳strSource指向的字符串
//
//    printf("=============\n");
//    char *pt = "zhushuai";
//    strcpy(str, pt);
//    printf("%s\n", str);
//
//    //char *strncpy(char *strDest, const char *strSource, size_t size)
//    //这个函数不会在末尾增加'\0'
//    //相比于源字符串只是替换
//    printf("=============\n");
//    char str1[10];
//    strncpy(str1, pt, 2);
//    printf("%s\n", str1);
//
//    return 0;
//}