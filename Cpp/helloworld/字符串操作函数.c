////
//// Created by shuncs on 19-2-28.
////
//
//#include <stdio.h>
//#include <stdlib.h>
//#include <string.h>
//
//int main(void)
//{
//    //strlen用来获取字符串长度
//    //strlen返回的是无符号的整形
//    //返回的长度不包括'\0'
//    char *p = "zhushuai";
//    size_t  len = strlen(p);
//    printf("%lu\n", len);
//
//    //int strcmp(const char *str1, const char *str2);
//    //int strncmp(const char *str1, const char *str2, size_t size); --- 比较前size个字符
//    printf("%d\n", strcmp("abcf", "abce"));
//
//    //char *strcat(char *strDestation, const char *strSource);
//    //参数一是目的字符数组
//    //参数二可以是常量字符串，也可以是字符数组
//    char str[20] = "abc";
//    printf("%s\n", str);
//    strcat(str, "defg");
//    printf("%s\n", str);
//
//    //int atoi(const char *str);
//    //第一个字符必须是数字字符，否则直接返回0
//    int a = atoi("12345");
//    printf("%d\n", a);
//    //char *itoa(int value, char *str, int radix);
//    //第一个参数字符是数字值
//    //第一个参数是字符存放的地址
//    //第三个参数是进制类型
//
//    char nstr[20];
//    sprintf(nstr, "%d,%c,%f", 12, 'v', 12.3f);
//    printf("%s\n", nstr);
//    //out:12,v,12.300000
//
//    return 0;
//}