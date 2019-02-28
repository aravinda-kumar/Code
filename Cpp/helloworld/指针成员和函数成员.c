////
//// Created by shuncs on 19-2-28.
////
//
//#include <stdio.h>
//
//void fun(void);
//
//struct Stu
//{
//    //在结构体中定义函数指针
//    void (*pt)(void);
//};
//
//int main(void)
//{
//    struct Stu stu = {fun};
//    stu.pt();
//
//    return 0;
//}
//
//void fun(void)
//{
//    printf("this is a function!\n");
//}