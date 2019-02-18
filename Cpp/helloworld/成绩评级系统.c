////
//// Created by zhushuai on 19-2-18.
////
//
//#include <stdio.h>
//
//int main(void)
//{
//    //提示欢迎
//    printf("欢迎使用!\n");
//
//    //初始化输入成绩的变量，初始化的变量值不影响数据的操作值
//    int score = -2;
//
//    //进入循环，可以重复输入变量
//    while (1)
//    {
//        printf("请输入成绩:");
//        scanf("%d", &score);
//        //输入的成绩如果是-1，则结束循环
//        if(-1 == score)
//        {
//            printf("谢谢使用!\n");
//            break;
//        }
//        else
//        {
//            //进行分级评估
//            if (score < 60)
//            {
//                printf("不及格\n");
//            }
//            else if (score >= 60 && score < 70)
//            {
//                printf("中等\n");
//            }
//            else if (score >= 70 && score < 80)
//            {
//                printf("良好\n");
//            }
//            else if (score >= 80 && score < 90)
//            {
//                printf("优秀\n");
//            }
//            else if (score >= 90 && score <= 100)
//            {
//                printf("完美\n");
//            }
//            else
//            {
//                printf("成绩有误，请重新输入!\n");
//            }
//        }
//    }
//
//    return 0;
//}