////
//// Created by shuncs on 19-3-2.
////
//
//#include <stdio.h>
//
//static void fun(void)
//{
//    int a = 1;
//    static int b = 1;
//    a++;
//    b++;
//    printf("a=%d\tb=%d\n", a, b);
//}
//
//int main(void)
//{
//    {
//        static int a;
//        printf("%p\t%d\n", &a, a);
//        {
//            printf("==========================\n");
//            static int a;
//            printf("%p\t%d\n", &a, a);
//            printf("==========================\n");
//        }
//    }
//    {
//        static int a;
//        printf("%p\t%d\n", &a, a);
//    }
//
//    for(int i=0;i<3;i++)
//    {
//        fun();
//    }
//
//    return 0;
//}