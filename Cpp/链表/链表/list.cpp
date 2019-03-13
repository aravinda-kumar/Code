#include"list.h"

//构造函数
List::List()
{

}

//析构函数
List::~List()
{
	//链表空间释放 -- 清空
	void FreeList();
}

//在指定位置添加节点
void List::AddListRand(const unsigned int pos, Node *node)
{
	//用来寻址的指针,pos的左右两个节点
	Node *pTmpLeft = g_pHead;
	Node *pTmpRight = pTmpLeft;

	//用来统计链表现有的节点数
	unsigned int nCount = CountList();

	//插入的位置是第一个节点
	if (pos == 1)
	{
		//将头节点连上即可
		node->pNext = g_pHead;
		g_pHead = node;
	}
	else if (pos >= nCount)
	{
		//插入的节点在最后，尾节点连上即可
		g_pEnd->pNext = node;
		node->pNext = NULL;
		g_pEnd = node;
	}
	else
	{
		//插入的位置在中间
		//找到插入点的左右两个节点
		for (unsigned int i = 0; i < pos - 2; i++)
		{
			pTmpLeft = pTmpLeft->pNext;
		}
		
		//节点进行连接
		pTmpRight = pTmpLeft->pNext;
		pTmpLeft->pNext = node;
		node->pNext = pTmpRight;
	}

}

unsigned int List::CountList()
{
	//如果头指针是空，没有元素，返回0
	if (g_pHead == NULL)
	{
		return 0;
	}
	//暂存头指针
	Node *pTmp = g_pHead;
	//统计节点个数
	unsigned int nCount = 0;
	while (pTmp != NULL)
	{
		nCount++;
		pTmp = pTmp->pNext;
	}
	return nCount;
}

//查询指定的节点
Node* List::SelectList(int a)
{
	Node *pTemp = g_pHead;
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

//链表的遍历
void List::ScanList()
{
	Node *pTemp = g_pHead;
	while (pTemp != NULL)
	{
		printf("node.a=%d\n", pTemp->a);
		pTemp = pTemp->pNext;
	}
}

//头节点增加
void List::AddNodeToListHead(int a)
{
	//创建一个节点
	Node *pTemp = (Node *)malloc(sizeof(Node));
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
void List::AddNodeToListTail(int a)
{
	//尾添加
	//创建一个节点
	Node *pTmp = (Node *)malloc(sizeof(Node));

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

//链表空间释放 -- 清空
void List::FreeList()
{
	//遍历整个链表
	Node *pTemp = g_pHead;
	while (g_pHead != NULL)
	{
		//头指针后移一个
		g_pHead = g_pHead->pNext;
		free(pTemp);
		pTemp = g_pHead;
	}
	//尾指针的位置已经释放了，所以给一个空指针就可以
	//free(g_pEnd);
	g_pEnd = NULL;
}

//头删除
void List::DeleteListHead()
{
	if (g_pHead != NULL)
	{
		Node *pTmp = g_pHead;
		//让下一个节点变成头接电脑
		g_pHead = g_pHead->pNext;
		//释放原有的头结点
		free(pTmp);
	}
	else
	{
		printf("链表为空，无法释放");
		return;
	}
}

//尾删除
void List::DeleteListTail()
{
	if (g_pEnd == g_pHead && g_pHead != NULL)
	{
		free(g_pHead);
		g_pHead = NULL;
		g_pEnd = NULL;
	}
	else if (g_pHead != NULL)
	{
		////用来寻找尾节点和尾节点的前一个节点的指针
		//struct Node *pTmpLeft = g_pHead;
		//struct Node *pTmpRight = g_pHead->pNext;
		//
		////尾节点的指针指向的是空
		//while (pTmpRight->pNext != NULL)
		//{
		//	pTmpRight = pTmpRight->pNext;
		//	pTmpLeft = pTmpLeft->pNext;
		//}
		//
		////重新是设置尾节点
		//g_pEnd = pTmpLeft;
		//g_pEnd->pNext = NULL;

		////释放原有尾节点
		//free(pTmpRight);

		//优化
		Node *pTemp = g_pHead;
		while (pTemp->pNext != g_pEnd)
		{
			//找到倒数第二个节点
			pTemp = pTemp->pNext;
		}
		//释放原来的尾节点
		free(g_pEnd);
		//重新设置尾节点
		g_pEnd = pTemp;
		g_pEnd->pNext = NULL;
	}
	else
	{
		printf("链表为空，无法释放");
		return;
	}
}

//删除指定节点
void List::DeleteListRand(int a)
{
	//链表判断
	if (g_pHead == NULL)
	{
		printf("链表为空，无法删除\n");
		return;
	}
	//链表不为空，找到这个节点
	Node* pTemp = SelectList(a);
	if (pTemp == NULL)
	{
		printf("没有这个节点\n");
		return;
	}

	//找到这这个节点
	if (g_pHead == g_pEnd)
	{
		free(g_pHead);
		g_pHead = NULL;
		g_pEnd = NULL;
	}
	//有两个节点
	else if (g_pHead->pNext == g_pEnd)
	{
		//删除头节点或者尾节点
		if (g_pHead == pTemp)
		{
			DeleteListHead();
		}
		else
		{
			DeleteListTail();
		}
	}
	else //有多个节点
	{
		if (g_pHead == pTemp)
		{
			DeleteListHead();
		}
		else if (g_pEnd == pTemp)
		{
			DeleteListTail();
		}
		else
		{
			Node *pTempLeft = g_pHead;
			while (pTempLeft->pNext != pTemp)
			{
				pTempLeft = pTempLeft->pNext;
			}
			//节点连接
			pTempLeft->pNext = pTemp->pNext;
			//释放pTemp
			pTemp->pNext = NULL;
			free(pTemp);
		}
	}
}