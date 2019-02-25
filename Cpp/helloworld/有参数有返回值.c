////
//// Created by shuncs on 19-2-25.
////
//
//#include <stdio.h>
//
//int FindMaxValue(const int *p, int nLength)
//{
//    int maxValue = p[0];
//    for(int i=1;i<nLength;i++)
//    {
//        if(maxValue < p[i])
//        {
//            maxValue = p[i];
//        }
//    }
//    return maxValue;
//}
//
//
//int main(void)
//{
//    int a[5] = {12,3,433,23,5};
//    printf("最大值是:%d\n", FindMaxValue(a, 5));
//
//    return 0;
//}