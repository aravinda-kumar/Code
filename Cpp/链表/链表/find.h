#ifndef _FIND_H_
#define _FIND_H_

#include<stdio.h>
#include"struct.h"

//查询指定的节点
struct Node* SelectList(int a);

//链表的头指针
extern struct Node *g_pHead;
//链表的尾指针
extern struct Node *g_pEnd;

#endif // !_FIND_H_

