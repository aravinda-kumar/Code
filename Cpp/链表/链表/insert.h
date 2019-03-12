#ifndef _INSERT_H_
#define _INSERT_H_

#include<stdio.h>
#include<stdlib.h>
#include"struct.h"

//链表的头指针
extern struct Node *g_pHead;
//链表的尾指针
extern struct Node *g_pEnd;

//在指定位置添加节点
void AddListRand(const unsigned int pos, struct Node *node);

//统计节点个数
unsigned int CountList();

#endif // !_INSERT_H_

