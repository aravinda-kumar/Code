////
//// Created by shuncs on 19-3-1.
////
//
//#include <stdio.h>
//
//#pragma pack(4)
//
//struct Stu
//{
//    //结构体成员的定义最好使用从小到大安排，便于节省空间
//    char c;     //一个字节
//
//    int i;      //四个字节
//    double d;   //八个字节
//    short s;    //两个字节
//};
//
//int main(void)
//{
//    //结构体的大小不是简单的所有成员大小之和
//    //结构体的大小建立在内存对齐的基础上
//    //以最大类型为字节对齐宽度
//    //依次填补各个成员字节
//    //结尾补齐
//    size_t size = sizeof(struct Stu);
//    printf("size = %lu\n", size);
//
//
//    return 0;
//}