#include<stdio.h>
#include<stdlib.h>

//定义节点结构体
struct Node
{
	int a;					//数据成员
	struct Node *pNext;		//指向下一个节点的指针
};

//头尾指针定义
struct Node *g_pHead;
struct Node *g_pEnd = NULL;

//尾添加
void AddListTail(int a);

//头添加
void AddListHead(int a);

//空头链表初始化
void InitList();

//创建节点函数
struct Node* CreateNode(int a);

int main(void)
{
	//链表空头初始化
	InitList();

	//操作
	AddListHead(5);
	AddListHead(21);
	AddListHead(14);
	AddListHead(112);
	AddListHead(0);

	system("pause");
	return 0;
}

//尾添加
void AddListTail(int a)
{
	struct Node *pTmp = CreateNode(a);

	//连接
	g_pEnd->pNext = pTmp;
	g_pEnd = pTmp;
}

//头添加
void AddListHead(int a)
{
	//申请空间
	struct Node *pTmp = CreateNode(a);

	//链接节点
	pTmp->pNext = g_pHead;
	g_pHead = pTmp;
}

//空头链表初始化
void InitList()
{
	//链表空头
	g_pHead = (struct Node *)malloc(sizeof(struct Node));
	g_pHead->pNext = NULL;
	g_pEnd = g_pHead;
}

//创建节点函数
struct Node* CreateNode(int a)
{
	//创建一个节点
	struct Node *pTmp = (struct Node *)malloc(sizeof(struct Node));

	if (NULL == pTmp)
	{
		printf("空间申请失败");
		return NULL;
	}

	//节点成员赋值
	pTmp->a = a;
	pTmp->pNext = NULL;

	return pTmp;
}