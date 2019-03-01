////
//// Created by shuncs on 19-3-1.
////
//
//#include <stdio.h>
//
////联合测大小端
//union Un
//{
//    int i;
//    char ch[4];
//};
//
//int main(void)
//{
//    int a = 134480385;
//    char *p = (char *)(&a);
//    printf("%p, %p, %p, %p\n", p, p+1, p+2, p+3);
//    printf("%d, %d, %d, %d\n", p[0], p[1], p[2], p[3]);
//
//    union Un un = {134480385};
//    printf("%d, %d, %d, %d\n", un.ch[0], un.ch[1], un.ch[2], un.ch[3]);
//
//    return 0;
//}