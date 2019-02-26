//
// Created by shuncs on 19-2-26.
//

#include <stdio.h>

void prints(const char *p);

int main(void)
{

    //'\0'本身也要占用一个字符
    //声明之后的字符串只能一个一个独立赋值，只可以在定义的时候使用花括号
    //字符数组只能单独赋值
    char ch[] = {'s', 'h', 'u', 'a', 'i', '\0'};

    printf("%s\n", ch);

    printf("=========\n");

    puts(&ch[0]);

    prints(ch);

    //常量字符串---自带'\0'
    //双引号的作用，返回常量字符串的首地址
    //z h u s h u a i \0 --- 这个才是字符数组本身
    //常量字符串不能被修改
    //字符指针的指向可以发生改变，但是常量字符串的内容不能发生改变
    //系统在字符常量去放置一份zhushuai字符常量，赋值给数组ptr时，在栈区复制一份常量字符串的内容
    //后续对ptr数组的操作都是操作的栈区的数据，所以可操作，字符常量区的内容并没有发生变化
    char ptr[] = "zhushuai";
    //printf是一个参数个数不确定函数，第一个函数是char*，指向一个字符串即可
    ptr[1] = 'a';
    printf("%s\n", ptr);

    return 0;
}

void prints(const char *p)
{
    int i=0;
    while(p[i] != '\0')
    {
        printf("%c", p[i++]);
    }
    printf("\n");
}