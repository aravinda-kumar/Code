
#include "AddNode.h"

//ͷ�ڵ�����
void AddNodeToListHead(int a)
{
	//����һ���ڵ�
	struct Node *pTemp = (struct Node *)malloc(sizeof(struct Node));
	//�ڵ����ݸ�ֵ
	pTemp->a = a;
	//���ý�β��־
	pTemp->pNext = NULL;

	//�ڵ�����
	if (g_pHead == NULL || g_pEnd == NULL)
	{
		//ͷβָ���һ���ڵ�
		g_pHead = pTemp;
		g_pEnd = pTemp;
	}
	else
	{
		//�µĽڵ���ͷ�ڵ�
		pTemp->pNext = g_pHead;
		g_pHead = pTemp;
	}
}

//�����������������������ݣ�β���
void AddNodeToListTail(int a)
{
	//β���
	//����һ���ڵ�
	struct Node *pTmp = (struct Node *)malloc(sizeof(struct Node));

	//�ڵ����ݽ��и�ֵ
	pTmp->a = a;
	//���ý�β��־
	pTmp->pNext = NULL;

	//���ڵ����ӵ�������
	if (NULL == g_pHead)
	{
		//��һ������ڵ�,���ӵ�ͷ���
		g_pHead = pTmp;
	}
	else
	{
		//����ڵ�����
		g_pEnd->pNext = pTmp;
	}
	//����β�ڵ�
	g_pEnd = pTmp;
}


