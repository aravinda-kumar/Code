////
//// Created by zhushuai on 19-2-19.
////
//
//#include <stdio.h>
//
//int main(void)
//{
//    //声明二维数组
//    //{{2,3}, {4,5}, {6,7}}
//    int a[3][2] = {2,3,4,5,6,7};
//    //方括号的个数决定数组的维数
//    //a是数组名字
//    //前面的3表示，大的数组里面有3个小的一维数组
//    //2表示每个小数组里面有两个元素
//    //int表示每个小数组里面的元素是整形的
//    //元素的个数==2*3==sizeof(a)/4
//    printf("%d\n", sizeof(a));
//
//    //二维数组的定义，行可以省略，列不可以省略
//    //初始化的元素的个数不一定要整除列数
//    //地址值上 b = &b[0]=&b[0][0]
//    int b[][2]={1,2,3,4,5,6,7};
//    for(int i=0;i<3;i++)
//    {
//        for(int j=0;j<2;j++)
//        {
//            printf("%d\t", *(*(b+i)+j));
//        }
//        printf("\n");
//    }
//
//    return 0;
//}