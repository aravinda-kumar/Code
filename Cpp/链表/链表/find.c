
#include"find.h"

//查询指定的节点
struct Node* SelectList(int a)
{
	struct Node *pTemp = g_pHead;
	//遍历链表查找
	while (pTemp != NULL)
	{
		if (pTemp->a == a)
		{
			return pTemp;
		}
		pTemp = pTemp->pNext;
	}

	//没有找到
	return NULL;
}