////
//// Created by shuncs on 19-3-4.
////
//
//#include <stdio.h>
//#include <error.h>
//#include <string.h>
//
//
//typedef struct Node
//{
//    int num;
//    char name[10];
//    double height;
//    short age;
//}_Node;
//
//int main(void)
//{
//    FILE *pfile = fopen("qwe.txt", "r");
//    char str[10] = {0};
//    fread(str, sizeof(char), 3, pfile);
//    long a = ftell(pfile);
//
//    //关闭文件
//    fclose(pfile);
//    return 0;
//}