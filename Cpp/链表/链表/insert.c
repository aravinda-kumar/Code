//
//#include"insert.h"
//
////在指定位置添加节点
//void AddListRand(const unsigned int pos, struct Node *node)
//{
//	//用来寻址的指针,pos的左右两个节点
//	struct Node *pTmpLeft = g_pHead;
//	struct NOde *pTmpRight = pTmpLeft;
//
//	//用来统计链表现有的节点数
//	unsigned int nCount = CountList();
//
//	//插入的位置是第一个节点
//	if (pos == 1)
//	{
//		//将头节点连上即可
//		node->pNext = g_pHead;
//		g_pHead = node;
//	}
//	else if (pos >= nCount)
//	{
//		//插入的节点在最后，尾节点连上即可
//		g_pEnd->pNext = node;
//		node->pNext = NULL;
//		g_pEnd = node;
//	}
//	else
//	{
//		//插入的位置在中间
//		//找到插入点的左右两个节点
//		for (unsigned int i = 0; i < pos - 2; i++)
//		{
//			pTmpLeft = pTmpLeft->pNext;
//		}
//		
//		//节点进行连接
//		pTmpRight = pTmpLeft->pNext;
//		pTmpLeft->pNext = node;
//		node->pNext = pTmpRight;
//	}
//
//}
//
//unsigned int CountList()
//{
//	//如果头指针是空，没有元素，返回0
//	if (g_pHead == NULL)
//	{
//		return 0;
//	}
//	//暂存头指针
//	struct Node *pTmp = g_pHead;
//	//统计节点个数
//	unsigned int nCount = 0;
//	while (pTmp != NULL)
//	{
//		nCount++;
//		pTmp = pTmp->pNext;
//	}
//	return nCount;
//}