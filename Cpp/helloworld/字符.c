////
//// Created by shuncs on 19-2-26.
////
//
//#include <stdio.h>
//
//int main(void)
//{
////    printf("%c\n", 'A');
////    putchar('B');
////    putchar('\n');
////
////    //声明/定义一个字符变量
////    //加了单引号编译器会解释成字符，否则就是变量
////    char c = 'A';
////    char c2;
////    printf("%lu, %lu\n", sizeof(c), sizeof(char));
////    //有符号的char -128~127
////    //无符号的char 0~255
////    //共计256个数
////
////    //\n也是一个字符，所以c2会接受回车字符
////    //输入字符的时候需要连续输入，不可以用回车后输入
////    //也不允许中间有空格隔开
////    //在输入字符的时候要注意空格,回车之类字符的影响
////    //综合来讲，输入字符容易被缓冲区存留的内容影响，所以在输入字符前我们吧缓冲区清空就可以去掉这些影响
////    //如何清空缓冲区
////    //setbuf(stdin, NULL);
////    //while((c=getchar()) != '\n' && c != EOF);
////    scanf("%c", &c);
////    //这种方法必须使用回车后再次输入
////    setbuf(stdin, NULL);
////    scanf("%c", &c2);
////
////
////    printf("%c\n", c);
////    printf("%c\n", c2);
////
////    printf("=================\n");
//
//    char ch;
////    char ch1;
////    while((ch=(char)getchar()) != '\n' && ch != EOF);
////    while((ch1=(char)getchar()) != '\n' && ch1 != EOF);
////    while(1)
////    {
////        ch = (char)getchar();
////        if(ch == '\n' || ch == EOF)
////        {
////            break;
////        }
////    }
////    ch = getchar();
////    ch1 = getchar();
//    printf("%c\n", ch);
//    printf("=================\n");
//
//    //printf("%c\n", ch1);
//
//    return 0;
//}