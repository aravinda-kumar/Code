////
//// Created by shuncs on 19-2-23.
////
//
//#include <stdio.h>
//
//int main(void)
//{
//    //指针数组拉链结构
//    //指针数组中的每一个元素都是一个数组的首地址
//    int b[3] = {1,2,3};
//    int c[2] = {4,5};
//    int d[4] = {6,7,8,9};
//    int e[5] = {10,11,12,13,14};
//    int f[2] = {15,16};
//
//    //指针数组的拉链结构
//    int* a[5] = {b,c,d,e,f};
//
//    //访问格式跟二维数组一样，意义也是一样的
//    //但是内存结构不一样，或者本质不一样
//    //每个小数组大小可以不同，但是元素类型必须相同
//    printf("%d\n", a[2][2]);
//
//
//    return 0;
//}