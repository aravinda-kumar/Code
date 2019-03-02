////
//// Created by shuncs on 19-3-2.
////
//
//#include <stdio.h>
//
//void fun(void)
//{
//    const char *p = "asd";
//    printf("%p\n", p);
//}
//
//
//
//int main(void)
//{
//    {
//        const char *p = "asd";
//        printf("%p\n", p);
//    }
//
//    {
//        const char *p = "asd";
//        printf("%p\n", p);
//    }
//
//    fun();
//
//    const int a = 12;
//
//    int *p = (int *)&a;
//    *p = 14;
//    printf("%d\n", a);
//
//    return 0;
//}