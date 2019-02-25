////
//// Created by shuncs on 19-2-25.
////
//
//#include <stdio.h>
//
//void fun(int a, double d);
//void fun1(int a)
//{
//    a = 12;
//}
//
//void fun2(int *p)
//{
//    *p = 12;
//}
//
//void fun3(int *p)
//{
//    //传进来的是p的内容
//    //所以在此改变p的内容将无济于事
//    p = NULL;
//}
//
////要修改变量，就要传递变量的地址
//void fun4(int **p)
//{
//    *p = NULL;
//}
////数组做形参会被解释成为指针，这两种形式本质没有任何区别
////void fun5(const int p[], int nLength)
//void fun5(const int *p, int nLength)
//{
//    for(int i=0;i<nLength;i++)
//    {
//        printf("%d\t", *(p+i));
//    }
//    printf("\n");
//}
//
//void fun6(const int(*p)[3], int row, int col)
//{
//    for(int i=0;i<row;i++)
//    {
//        for(int j=0;j<col;j++)
//            printf("%d\t", *(*(p+i)+j));
//        printf("\n");
//    }
//}
//
//int main(void)
//{
//    int c = 10;
//    double d = 12.34;
//    fun(c, d);
//
//    printf("====================\n");
//
//    int a = 0;
//    printf("original:%d\n", a);
//    fun1(a);
//    printf("fun1(a):%d\n", a);
//    fun2(&a);
//    printf("fun2(&a):%d\n", a);
//
//    printf("====================\n");
//
//    int *p = &a;
//    printf("%p\n", p);
//    fun3(p);
//    printf("%p\n", p);
//    fun4(&p);
//    printf("%p\n", p);
//
//    printf("====================\n");
//    int arr[5] = {1,32,32,4,35};
//    fun5(arr, 5);
//
//    printf("====================\n");
//    //arr2[0][0]中存放的是元素值
//    //arr2[0]中存放的是arr2[0][0]的地址
//    //arr2中存放的是arr2[0]的地址
//    int arr2[2][3] = {1,2,3,4,5,6};
//    fun6(arr2, 2, 3);
//
//
//    return 0;
//}
//
//void fun(int a, double d)
//{
//    printf("a=%d, d=%.2lf\n", a, d);
//}