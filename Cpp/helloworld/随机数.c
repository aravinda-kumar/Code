////
//// Created by zhushuai on 19-3-2.
////
//
//#include <stdio.h>
//#include <stdlib.h>
//#include <time.h>
//
//int main(void)
//{
//    //随机数种子
//    //基准数
//    //只调用一次就可以了
//    //没有srand() == srand(1)
//    srand((unsigned int)time(NULL));
//    printf("%d\n\n", (int)time(NULL));
//    //产生随机数
//    for(int i=0;i<10;i++)
//    {
//        //产生0-78的随机数  rand()%79
//        printf("%d\n", rand()%79);
//    }
//
//    printf("===================\n");
//
//    for(int i=0;i<10;i++)
//    {
//        //产生100-999的随机数
//        //产生0-899 然后再加100 rand()%900+100
//        printf("%d\n", rand()%900+100);
//    }
//
//    printf("===================\n");
//
//    for(int i=0;i<10;i++)
//    {
//        //产生50-120的随机数
//        //产生0-70 然后再加50 rand()%900+100
//        printf("%d\n", rand()%71+50);
//    }
//
//    //随机产生一组数中的一个
//    //思路
//    //将其加入一个数组 --- int a[10]
//    //随机产生一个下标
//    int a[10] = {12, 8, 352, 65, 7984, 13, 45, 65, 5, 0};
//    int pos = 0;
//    for(long long i=0;i<10000;i++)
//    {
//        pos = rand()%10;
//        printf("%d---%d\n", pos, a[pos]);
//    }
//
//
//    return 0;
//}