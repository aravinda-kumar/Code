#ifndef _INSERT_H_
#define _INSERT_H_

#include<stdio.h>
#include<stdlib.h>
#include"struct.h"

//�����ͷָ��
extern struct Node *g_pHead;
//�����βָ��
extern struct Node *g_pEnd;

//��ָ��λ����ӽڵ�
void AddListRand(const unsigned int pos, struct Node *node);

//ͳ�ƽڵ����
unsigned int CountList();

#endif // !_INSERT_H_

