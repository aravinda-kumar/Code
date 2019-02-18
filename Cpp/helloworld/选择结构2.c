////
//// Created by zhushuai on 19-2-18.
////
//
//#include <stdio.h>
//
//int main(void)
//{
//    int order = -1;
//    scanf("%d", &order);
//    //switch中内容必须是整形表达式
//    //循环和switch混用的时候，break只会跳出switch不会跳出循环
//    switch (order)
//    {
//        //case后面必须跟整形常量表达式
//        //case后面的标签值不能够重复
//        //if...else...条件重复的时候不会产生错误，这种写法被允许
//        //case中需要定义变量，需要使用花括号，形成代码块；
//        //default作为默认处理，非必须
//        //最后一个标签的break可以省略，不论这个break属于谁
//        case 0:
//            printf("添加一个学生\n");
//            break; //没有break程序会一直向下进行，直到遇到break；
//        case 1:
//            printf("删除一个学生\n");
//            break; //break用来跳出switch结构
//        case 2:
//            printf("浏览学生信息\n");
//            break;
//        case 3:
//            printf("退出系统\n");
//            break;
//        default:
//            printf("指令错误!\n");
//    }
//    printf("%d\n", (int)(66.6)/10);
//
//    return 0;
//}