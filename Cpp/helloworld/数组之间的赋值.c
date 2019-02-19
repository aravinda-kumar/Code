//
// Created by zhushuai on 19-2-19.
//

#include <stdio.h>
#include <string.h>

int main(void)
{
    int a[5] = {1,2,3,4,5};
    int b[5];
    int c[3];
    //数组的备份
    //1.循环赋值
    for(int i=0;i<5;i++)
    {
        b[i]=a[i];
    }
    for(int i=0;i<3;i++)
    {
        c[i]=a[i+2];
    }
    //2.memcpy(目标， 源， 复制的字节数)
    //注意：第三个参数是复制的字节数，不是复制的元素的个数
    memcpy(b, a, sizeof(int)*5);
    for(int i=0;i<5;i++)
    {
        printf("%d\t", b[i]);
    }
    return 0;
}