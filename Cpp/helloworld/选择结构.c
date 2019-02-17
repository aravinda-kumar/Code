//
// Created by zhushuai on 19-2-17.
//

#include <stdio.h>
#include <stdlib.h>

int main(void)
{
    //表示成绩的变量
    //输入一个成绩
    //判断
    //满足---打印及格
    //不满足---跳出程序结束

    //变量初始化的值一定不要影响到其本身的值
    int score = -1;
    printf("请输入成绩：");
    scanf("%d", &score);
    if(score >= 60)
    {
        printf("成绩合格！\n");
    }

    return 0;
}