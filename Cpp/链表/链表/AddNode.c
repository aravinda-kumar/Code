
#include "AddNode.h"

//头节点增加
void AddNodeToListHead(int a)
{
	//创建一个节点
	struct Node *pTemp = (struct Node *)malloc(sizeof(struct Node));
	//节点数据赋值
	pTemp->a = a;
	//设置结尾标志
	pTemp->pNext = NULL;

	//节点连接
	if (g_pHead == NULL || g_pEnd == NULL)
	{
		//头尾指向第一个节点
		g_pHead = pTemp;
		g_pEnd = pTemp;
	}
	else
	{
		//新的节点作头节点
		pTemp->pNext = g_pHead;
		g_pHead = pTemp;
	}
}

//创建链表，在链表中增加数据，尾添加
void AddNodeToListTail(int a)
{
	//尾添加
	//创建一个节点
	struct Node *pTmp = (struct Node *)malloc(sizeof(struct Node));

	//节点数据进行赋值
	pTmp->a = a;
	//设置结尾标志
	pTmp->pNext = NULL;

	//将节点链接到链表上
	if (NULL == g_pHead)
	{
		//第一个链表节点,链接到头结点
		g_pHead = pTmp;
	}
	else
	{
		//链表节点连接
		g_pEnd->pNext = pTmp;
	}
	//生成尾节点
	g_pEnd = pTmp;
}


