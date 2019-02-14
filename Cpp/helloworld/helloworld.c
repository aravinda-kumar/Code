////
//// Created by zhushuai on 19-2-13.
////
//
////标准输入输出头文件standard input and output
//#include <stdio.h>
////标准库头头文件 standard library
//#include <stdlib.h>
//
////main一个应用程序的入口
////操作系统调用应用程序的接口
////一个项目只能有一个main函数
//
////几种main函数的形式
////标准形式一 int main(void){ return0; )
////标准形式二 int main(int argc, char* arg[]){ return 0;} 用于命令行参数
////常见形式一 int main(){ return 0;} c++的标准形式
////常见形式二 main(){} 老版本的c语言支持，c++不支持，不建议这种写法
////常见形式三 void main(){} 编译器支持，但是不推荐
//
//int main(void)
//{
//    //打印一句话
//    printf("Hello World!\n"); //转义字符
//    //内建函数
//    //常用函数例如printf()已经被编译器作为了一个属性
//    //printf()在调用的时候，即使没有头文件也能执行
//    //GetLastError();不是内建函数
//
//    return 0;
//}