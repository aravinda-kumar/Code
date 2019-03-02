////
//// Created by shuncs on 19-3-2.
////
//
//#include <stdio.h>
//#include <string.h>
//
//const int* fun(const int *p);
//int a = 15;
//int main(void)
//{
////    const int a = 12;
////    //a = 34;
////    printf("a=%d\n", a);
////    int *p = (int *)&a;
////    *p = 15;
////
////    printf("a=%d\n", a);
////
////    const int arr[3] = {12,13,14};
////    for(int i=0;i<3;i++)
////    {
////        printf("%d\t", arr[i]);
////    }
////    printf("\n");
////    int *pt = (int *)arr;
////    pt[2] = 16;
////    for(int i=0;i<3;i++)
////    {
////        printf("%d\t", arr[i]);
////    }
////    printf("\n");
//
////    int a = 12;
////    int b = 23;
////    printf("==================\n");
////    const int *p = &a;
////    p = &b;
////
////    int* const pt = &a;
////    *pt = 14;
////    const int * const p1 = &a;
//
//    int a = 12;
//    const int *p;
//    p = fun(&a);
//    printf("%d\n", *p);
//
//    return 0;
//}
//
//const int* fun(const int *p)
//{
//    a = *p;
//    return &a;
//}