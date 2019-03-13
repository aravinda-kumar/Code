//#include"delete.h"
//
////链表空间释放 -- 清空
//void FreeList()
//{
//	//遍历整个链表
//	struct Node *pTemp = g_pHead;
//	while (g_pHead != NULL)
//	{
//		//头指针后移一个
//		g_pHead = g_pHead->pNext;
//		free(pTemp);
//		pTemp = g_pHead;
//	}
//	//尾指针的位置已经释放了，所以给一个空指针就可以
//	//free(g_pEnd);
//	g_pEnd = NULL;
//}
//
////头删除
//void DeleteListHead()
//{
//	if (g_pHead != NULL)
//	{
//		struct Node *pTmp = g_pHead;
//		//让下一个节点变成头接电脑
//		g_pHead = g_pHead->pNext;
//		//释放原有的头结点
//		free(pTmp);
//	}
//	else
//	{
//		printf("链表为空，无法释放");
//		return;
//	}
//}
//
////尾删除
//void DeleteListTail()
//{
//	if (g_pEnd == g_pHead && g_pHead != NULL)
//	{
//		free(g_pHead);
//		g_pHead = NULL;
//		g_pEnd = NULL;
//	}
//	else if (g_pHead != NULL)
//	{
//		////用来寻找尾节点和尾节点的前一个节点的指针
//		//struct Node *pTmpLeft = g_pHead;
//		//struct Node *pTmpRight = g_pHead->pNext;
//		//
//		////尾节点的指针指向的是空
//		//while (pTmpRight->pNext != NULL)
//		//{
//		//	pTmpRight = pTmpRight->pNext;
//		//	pTmpLeft = pTmpLeft->pNext;
//		//}
//		//
//		////重新是设置尾节点
//		//g_pEnd = pTmpLeft;
//		//g_pEnd->pNext = NULL;
//
//		////释放原有尾节点
//		//free(pTmpRight);
//
//		//优化
//		struct Node *pTemp = g_pHead;
//		while (pTemp->pNext != g_pEnd)
//		{
//			//找到倒数第二个节点
//			pTemp = pTemp->pNext;
//		}
//		//释放原来的尾节点
//		free(g_pEnd);
//		//重新设置尾节点
//		g_pEnd = pTemp;
//		g_pEnd->pNext = NULL;
//	}
//	else
//	{
//		printf("链表为空，无法释放");
//		return;
//	}
//}
//
////删除指定节点
//void DeleteListRand(int a)
//{
//	//链表判断
//	if (g_pHead == NULL)
//	{
//		printf("链表为空，无法删除\n");
//		return;
//	}
//	//链表不为空，找到这个节点
//	struct Node* pTemp = SelectList(a);
//	if (pTemp == NULL)
//	{
//		printf("没有这个节点\n");
//		return;
//	}
//
//	//找到这这个节点
//	if (g_pHead == g_pEnd)
//	{
//		free(g_pHead);
//		g_pHead = NULL;
//		g_pEnd = NULL;
//	}
//	//有两个节点
//	else if (g_pHead->pNext == g_pEnd)
//	{
//		//删除头节点或者尾节点
//		if (g_pHead == pTemp)
//		{
//			DeleteListHead();
//		}
//		else
//		{
//			DeleteListTail();
//		}
//	}
//	else //有多个节点
//	{
//		if (g_pHead == pTemp)
//		{
//			DeleteListHead();
//		}
//		else if (g_pEnd == pTemp)
//		{
//			DeleteListTail();
//		}
//		else
//		{
//			struct Node *pTempLeft = g_pHead;
//			while (pTempLeft->pNext != pTemp)
//			{
//				pTempLeft = pTempLeft->pNext;
//			}
//			//节点连接
//			pTempLeft->pNext = pTemp->pNext;
//			//释放pTemp
//			pTemp->pNext = NULL;
//			free(pTemp);
//		}
//	}
//}