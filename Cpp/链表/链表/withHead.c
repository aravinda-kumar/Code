//#include<stdio.h>
//#include<stdlib.h>
//
////定义节点结构体
//struct Node
//{
//	int a;					//数据成员
//	struct Node *pNext;		//指向下一个节点的指针
//};
//
////头尾指针定义
//struct Node *g_pHead;
//struct Node *g_pEnd = NULL;
//
////尾添加
//void AddListTail(int a);
////头添加
//void AddListHead(int a);
////任意位置添加
//void AddListRand(const int pos, int a);
//
////空头链表初始化
//void InitList();
////创建节点函数
//struct Node* CreateNode(int a);
////遍历链表
//void ScanList();
////查到指定的节点的函数,并返回节点地址
//struct Node* SelctNode(int a);
//
////删除头节点
//void DeleteHead();
////删除尾节点
//void DeleteTail();
////删除任意节点
//void DeleteRand(int a);
////释放所有节点
//void FreeList();
//
//int main(void)
//{
//	//链表空头初始化
//	InitList();
//
//	//操作
//	AddListTail(1);
//	AddListTail(2);
//	AddListTail(3);
//	AddListTail(4);
//	AddListTail(5);
//
//	DeleteRand(1);
//	DeleteRand(2);
//	DeleteRand(3);
//	DeleteRand(4);
//	DeleteRand(5);
//	DeleteRand(5);
//
//	ScanList();
//
//	FreeList();
// 	system("pause");
//	return 0;
//}
//
////释放所有节点
//void FreeList()
//{
//	struct Node *pTmp = g_pHead;
//	while (pTmp != NULL)
//	{
//		//先将节点移动
//		struct Node *pt = pTmp;
//		pTmp = pTmp->pNext;
//		//再释放节点
//		free(pt);
//	}
//	g_pHead = g_pEnd = NULL;
//}
//
////删除任意节点
//void DeleteRand(int a)
//{
//	//判断链表是否为空
//	if (g_pHead->pNext == NULL)
//	{
//		printf("链表无节点\n");
//		return;
//	}
//
//	struct Node *pTmp = SelctNode(a);
//	if (pTmp == g_pHead->pNext)
//	{
//		DeleteHead();
//	}
//	else if (pTmp == g_pEnd)
//	{
//		DeleteTail();
//	}
//	else
//	{
//		struct Node *pTmpLeft = g_pHead;
//		while (pTmpLeft->pNext != pTmp)
//		{
//			pTmpLeft = pTmpLeft->pNext;
//		}
//		pTmpLeft->pNext = pTmp->pNext;
//		free(pTmp);
//	}
//}
//
////删除尾节点
//void DeleteTail()
//{
//	if (g_pHead->pNext == NULL)
//	{
//		printf("链表无节点\n");
//		return;
//	}
//	struct Node *pTmp = g_pHead;
//	//第三个节点是空
//	if (pTmp->pNext->pNext == NULL)
//	{
//		//将原来的尾节点向前走一个
//		g_pEnd = g_pHead;
//		g_pEnd->pNext = NULL;
//		//释放第二个节点
//		free(pTmp->pNext);
//	}
//	else
//	{
//		while (pTmp->pNext->pNext != NULL)
//		{
//			pTmp = pTmp->pNext;
//		}
//		free(g_pEnd);
//		g_pEnd = pTmp;
//		g_pEnd->pNext = NULL;
//	}
//}
//
////删除头节点
//void DeleteHead()
//{
//	struct Node* pTmp;
//	if (g_pHead->pNext == NULL)
//	{
//		printf("链表无节点\n");
//		return;
//	}
//	//找到实际的头结点
//	pTmp = g_pHead->pNext;
//	//连接新的头节点
//	g_pHead->pNext = pTmp->pNext;
//	//释放节点
//	free(pTmp);
//}
//
////任意位置添加
//void AddListRand(const int pos, int a)
//{
//	if (g_pHead->pNext == NULL)
//	{
//		printf("链表无节点\n");
//		return;
//	}
//	//确定要插入的节点的位置
//	struct Node* pTmp = SelctNode(pos);
//	if (pTmp == NULL)
//	{
//		printf("无此节点\n");
//		return;
//	}
//	if (pTmp == g_pEnd)
//	{
//		AddListTail(a);
//	}
//	else if (pTmp == g_pHead)
//	{
//		AddListHead(a);
//	}
//	else
//	{
//		struct Node* pNew = CreateNode(a);
//		pNew->pNext = pTmp->pNext;
//		pTmp->pNext = pNew;
//	}
//}
//
////查到指定的节点的函数,并返回节点地址
//struct Node* SelctNode(int a)
//{
//	struct Node *pTmp = g_pHead;
//	while(pTmp != NULL)
//	{
//		if (pTmp->a == a)
//		{
//			return pTmp;
//		}
//		pTmp = pTmp->pNext;
//	}
//	return NULL;
//}
//
////遍历链表
//void ScanList()
//{
//	struct Node *pTemp = g_pHead;
//	//避免遍历到头结点
//	while (pTemp != NULL)
//	{
//		printf("a=%d\n", pTemp->a);
//		pTemp = pTemp->pNext;
//	}
//}
//
////尾添加
//void AddListTail(int a)
//{
//	struct Node *pTmp = CreateNode(a);
//
//	//连接
//	g_pEnd->pNext = pTmp;
//	g_pEnd = pTmp;
//}
//
////头添加
//void AddListHead(int a)
//{
//	//申请空间
//	struct Node *pTmp = CreateNode(a);
//
//	//链接节点
//	pTmp->pNext = g_pHead;
//	g_pHead = pTmp;
//}
//
////空头链表初始化
//void InitList()
//{
//	//链表空头
//	g_pHead = (struct Node *)malloc(sizeof(struct Node));
//	g_pHead->pNext = NULL;
//	g_pEnd = g_pHead;
//}
//
////创建节点函数
//struct Node* CreateNode(int a)
//{
//	//创建一个节点
//	struct Node *pTmp = (struct Node *)malloc(sizeof(struct Node));
//
//	if (NULL == pTmp)
//	{
//		printf("空间申请失败");
//		return NULL;
//	}
//
//	//节点成员赋值
//	pTmp->a = a;
//	pTmp->pNext = NULL;
//
//	return pTmp;
//}