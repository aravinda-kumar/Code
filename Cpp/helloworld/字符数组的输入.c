////
//// Created by shuncs on 19-2-28.
////
//
//#include <stdio.h>
//
//int main(void)
//{
//    char str[20];
//    //输入越界会出现错误
//    //scanf不能读取空格，空格会当分隔符使用
//    //%c可以接收空格，%s不可以接收空格
//    //%s会在最后自动增加'\0',所以实际输入的字符个数要减少一个
////    scanf("%s", str);
////
////    printf("=====================\n");
////    printf("%s\n", str);
//
//    printf("=====================\n");
//    char str2[20];
//    //gets是可以读入空格的，但是也要注意越界问题
//    gets(str2);
//    printf("%s\n", str2);
//
//
//    return 0;
//}