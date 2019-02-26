////
//// Created by shuncs on 19-2-26.
////
//
//#include <stdio.h>
//
//int main(void)
//{
//    char ch[5] = {'s', 'h', 'u', 'a', 'i'};
//    printf("数组大小:%lu\n", sizeof(char[5]));
//    //*p指向字符数组
//    //p位字符数组的地址，对p取内容就是这个地址中的内容，这个地址中的内容是第一个元素的首地址
//    //再对这个元素取内容就是数组中的元素
//    char (*p)[5] = &ch;
//    for(int i=0;i<5;i++)
//    {
//        printf("%c\t", (*p)[i]);
//    }
//    printf("\n");
//
//    return 0;
//}