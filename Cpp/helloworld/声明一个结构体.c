////
//// Created by shuncs on 19-2-28.
////
//
//#include <stdio.h>
//#include <stdlib.h>
//#include <string.h>
//
////结构体最后一定要加分号
////在定义结构体的时候声明变量，结构体的名字可以不写
//struct Stu
//{
//    char name[10];
//    unsigned int age;
//    double height;
//    char num[20];
//}stu, stu1;
//
//int main(void)
//{
//    //在声明的时候初始化
//    struct Stu stu2 = {"johnson", 24, 123.34, "1234567"};
//    strcpy(stu.name, "asdf");
//    stu.age = 12;
//    stu.height = 1111.11;
//    strcpy(stu.num, "20190228");
//    printf("%s, %d, %.2lf, %s\n", stu2.name, stu2.age, stu2.height, stu2.num);
//
//    printf("===========================\n");
//
//    struct Stu *pt = &stu2;
//    printf("%s, %d, %.2lf, %s\n", pt->name, pt->age, pt->height, pt->num);
//
//    struct Stu *pt2 = (struct Stu*)malloc(sizeof(struct Stu));
//    strcpy(pt2->name, "jason");
//    pt2->age = 123;
//    pt2->height = 123.45;
//    strcpy(pt2->num, "1234556");
//    printf("%s, %d, %.2lf, %s\n", pt2->name, pt2->age, pt2->height, pt2->num);
//    free(pt2);
//
//    printf("===========================\n");
//
//    //复合文字结构赋值
//    stu1 = (struct Stu){"tamos", 12, 123.33, "20192023"};
//    printf("%s, %d, %.2lf, %s\n", stu1.name, stu1.age, stu1.height, stu1.num);
//
//    printf("===========================\n");
//
//    //初始化指定成员
//    struct Stu stu7 = {.age = 12};
//    printf("%s, %d, %.2lf, %s\n", stu7.name, stu7.age, stu7.height, stu7.num);
//
//    return 0;
//}