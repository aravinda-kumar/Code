////
//// Created by shuncs on 19-2-24.
////
//
//#include <stdio.h>
//#include <stdlib.h>
//#include <malloc.h>
//#include <string.h>
//
//int main(void)
//{
//    //malloc定义一维数组的第一种方式
//    //这种malloc的数组的大小可以通过scanf输入
//    //int size = -1;
//    //scanf("%d", &size);
//    //int *p = (int *)malloc(sizeof(int)*size);
//    int *p = (int *)malloc(sizeof(int)*5);
//    //memset(数组首地址, 所赋的值, 字节数)
//    memset(p, 0, sizeof(int)*5);
//    p[0] = 12;
//    for (int i = 0; i < 5; ++i)
//    {
//        printf("%d\t", p[i]);
//    }
//    printf("\n");
//    printf("%lu\n", sizeof(int(*)[5]));
//    printf("%p\n", p);
//    free(p);
//
//    //malloc定义一维数组的第二种方式
//    int (*pt)[5] = (int(*)[5])malloc(sizeof(int)*5);
//    for (int i = 0; i < 5; ++i)
//    {
//        printf("%d\t", (*pt)[i]);
//    }
//    printf("\n");
//    printf("%p\n", pt);
//    free(pt);
//
//    int (*pt1)[2][3] = (int(*)[2][3])malloc(sizeof(int)*2*3);
//
//    *(*(*pt1+0)+0) = 0;
//    *(*(*pt1+0)+1) = 1;
//    *(*(*pt1+0)+2) = 2;
//    *(*(*pt1+1)+0) = 3;
//    *(*(*pt1+1)+1) = 4;
//    *(*(*pt1+1)+2) = 5;
//
//    for(int i=0;i<2;i++)
//    {
//        for(int j=0;j<3;j++)
//            printf("%d\t", (*pt1)[i][j]);
//        printf("\n");
//    }
//
//    free(pt1);
//
//    return 0;
//}