////
//// Created by shuncs on 19-2-24.
////
//
//#include <stdio.h>
//#include <stdlib.h>
//#include <malloc.h>
//
//int main(void)
//{
//    //calloc申请一段空间数组
//    //void *calloc(size_t num, size_t size)
//    //calloc申请出的数组会自动赋值为0
//    int *p = (int*)calloc(5, sizeof(int));
//
//    for(int i=0;i<5;i++)
//    {
//        printf("%d\t", *(p+i));
//    }
//    printf("\n");
//
//    free(p);
//
//    //realloc---重新分配内存大小，原来8字节，重新分配成100字节或者5字节
//    //void *realloc(void *memblock, size_t size);
//    //注意点1：如果需要的空间在内存中够用，则自动在尾部追加
//    //注意点2：如果当前位置无法追加空间，但别的位置由，那么会在另一块空间创建连续空间，此时返回新的地址值，同时会把原来内存空间的值赋值到新的内存空间中
//    //注意点3：如果内存中无法再追加空间，则会默认返回NULL
//    int *pt = (int *)malloc(12);
//
//    pt = (int *)realloc(pt, 20);
//
//
//
//    free(pt);
//
//    return 0;
//}