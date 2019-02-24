////
//// Created by shuncs on 19-2-24.
////
//
//#include <stdio.h>
//
//int fun(const int *a, const int nLength)
//{
//    int maxNum = a[0];
//    for(int i=1;i<nLength;i++)
//    {
//        if(maxNum < a[i])
//        {
//            maxNum = a[i];
//        }
//    }
//    return maxNum;
//}
//
//int main(void)
//{
//    int a[5] = {12,3,45,6,7};
//    int b[6] = {23,4,223,12,4,5};
////    int maxNum = a[0];
////    for(int i=1;i<5;i++)
////    {
////        if(maxNum < a[i])
////        {
////            maxNum = a[i];
////        }
////    }
//    printf("最大值是：%d\n", fun(a, 5));
//
////    maxNum = b[0];
////    for(int i=1;i<6;i++)
////    {
////        if(maxNum < b[i])
////        {
////            maxNum = b[i];
////        }
////    }
//    printf("最大值是：%d\n", fun(b, 6));
//
//    return 0;
//}