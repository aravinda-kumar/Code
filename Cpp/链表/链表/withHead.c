//#include<stdio.h>
//#include<stdlib.h>
//
////����ڵ�ṹ��
//struct Node
//{
//	int a;					//���ݳ�Ա
//	struct Node *pNext;		//ָ����һ���ڵ��ָ��
//};
//
////ͷβָ�붨��
//struct Node *g_pHead;
//struct Node *g_pEnd = NULL;
//
////β���
//void AddListTail(int a);
////ͷ���
//void AddListHead(int a);
////����λ�����
//void AddListRand(const int pos, int a);
//
////��ͷ�����ʼ��
//void InitList();
////�����ڵ㺯��
//struct Node* CreateNode(int a);
////��������
//void ScanList();
////�鵽ָ���Ľڵ�ĺ���,�����ؽڵ��ַ
//struct Node* SelctNode(int a);
//
////ɾ��ͷ�ڵ�
//void DeleteHead();
////ɾ��β�ڵ�
//void DeleteTail();
////ɾ������ڵ�
//void DeleteRand(int a);
////�ͷ����нڵ�
//void FreeList();
//
//int main(void)
//{
//	//�����ͷ��ʼ��
//	InitList();
//
//	//����
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
////�ͷ����нڵ�
//void FreeList()
//{
//	struct Node *pTmp = g_pHead;
//	while (pTmp != NULL)
//	{
//		//�Ƚ��ڵ��ƶ�
//		struct Node *pt = pTmp;
//		pTmp = pTmp->pNext;
//		//���ͷŽڵ�
//		free(pt);
//	}
//	g_pHead = g_pEnd = NULL;
//}
//
////ɾ������ڵ�
//void DeleteRand(int a)
//{
//	//�ж������Ƿ�Ϊ��
//	if (g_pHead->pNext == NULL)
//	{
//		printf("�����޽ڵ�\n");
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
////ɾ��β�ڵ�
//void DeleteTail()
//{
//	if (g_pHead->pNext == NULL)
//	{
//		printf("�����޽ڵ�\n");
//		return;
//	}
//	struct Node *pTmp = g_pHead;
//	//�������ڵ��ǿ�
//	if (pTmp->pNext->pNext == NULL)
//	{
//		//��ԭ����β�ڵ���ǰ��һ��
//		g_pEnd = g_pHead;
//		g_pEnd->pNext = NULL;
//		//�ͷŵڶ����ڵ�
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
////ɾ��ͷ�ڵ�
//void DeleteHead()
//{
//	struct Node* pTmp;
//	if (g_pHead->pNext == NULL)
//	{
//		printf("�����޽ڵ�\n");
//		return;
//	}
//	//�ҵ�ʵ�ʵ�ͷ���
//	pTmp = g_pHead->pNext;
//	//�����µ�ͷ�ڵ�
//	g_pHead->pNext = pTmp->pNext;
//	//�ͷŽڵ�
//	free(pTmp);
//}
//
////����λ�����
//void AddListRand(const int pos, int a)
//{
//	if (g_pHead->pNext == NULL)
//	{
//		printf("�����޽ڵ�\n");
//		return;
//	}
//	//ȷ��Ҫ����Ľڵ��λ��
//	struct Node* pTmp = SelctNode(pos);
//	if (pTmp == NULL)
//	{
//		printf("�޴˽ڵ�\n");
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
////�鵽ָ���Ľڵ�ĺ���,�����ؽڵ��ַ
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
////��������
//void ScanList()
//{
//	struct Node *pTemp = g_pHead;
//	//���������ͷ���
//	while (pTemp != NULL)
//	{
//		printf("a=%d\n", pTemp->a);
//		pTemp = pTemp->pNext;
//	}
//}
//
////β���
//void AddListTail(int a)
//{
//	struct Node *pTmp = CreateNode(a);
//
//	//����
//	g_pEnd->pNext = pTmp;
//	g_pEnd = pTmp;
//}
//
////ͷ���
//void AddListHead(int a)
//{
//	//����ռ�
//	struct Node *pTmp = CreateNode(a);
//
//	//���ӽڵ�
//	pTmp->pNext = g_pHead;
//	g_pHead = pTmp;
//}
//
////��ͷ�����ʼ��
//void InitList()
//{
//	//�����ͷ
//	g_pHead = (struct Node *)malloc(sizeof(struct Node));
//	g_pHead->pNext = NULL;
//	g_pEnd = g_pHead;
//}
//
////�����ڵ㺯��
//struct Node* CreateNode(int a)
//{
//	//����һ���ڵ�
//	struct Node *pTmp = (struct Node *)malloc(sizeof(struct Node));
//
//	if (NULL == pTmp)
//	{
//		printf("�ռ�����ʧ��");
//		return NULL;
//	}
//
//	//�ڵ��Ա��ֵ
//	pTmp->a = a;
//	pTmp->pNext = NULL;
//
//	return pTmp;
//}