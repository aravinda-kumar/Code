#include"list.h"

//���캯��
List::List()
{

}

//��������
List::~List()
{
	//����ռ��ͷ� -- ���
	void FreeList();
}

//��ָ��λ����ӽڵ�
void List::AddListRand(const unsigned int pos, Node *node)
{
	//����Ѱַ��ָ��,pos�����������ڵ�
	Node *pTmpLeft = g_pHead;
	Node *pTmpRight = pTmpLeft;

	//����ͳ���������еĽڵ���
	unsigned int nCount = CountList();

	//�����λ���ǵ�һ���ڵ�
	if (pos == 1)
	{
		//��ͷ�ڵ����ϼ���
		node->pNext = g_pHead;
		g_pHead = node;
	}
	else if (pos >= nCount)
	{
		//����Ľڵ������β�ڵ����ϼ���
		g_pEnd->pNext = node;
		node->pNext = NULL;
		g_pEnd = node;
	}
	else
	{
		//�����λ�����м�
		//�ҵ����������������ڵ�
		for (unsigned int i = 0; i < pos - 2; i++)
		{
			pTmpLeft = pTmpLeft->pNext;
		}
		
		//�ڵ��������
		pTmpRight = pTmpLeft->pNext;
		pTmpLeft->pNext = node;
		node->pNext = pTmpRight;
	}

}

unsigned int List::CountList()
{
	//���ͷָ���ǿգ�û��Ԫ�أ�����0
	if (g_pHead == NULL)
	{
		return 0;
	}
	//�ݴ�ͷָ��
	Node *pTmp = g_pHead;
	//ͳ�ƽڵ����
	unsigned int nCount = 0;
	while (pTmp != NULL)
	{
		nCount++;
		pTmp = pTmp->pNext;
	}
	return nCount;
}

//��ѯָ���Ľڵ�
Node* List::SelectList(int a)
{
	Node *pTemp = g_pHead;
	//�����������
	while (pTemp != NULL)
	{
		if (pTemp->a == a)
		{
			return pTemp;
		}
		pTemp = pTemp->pNext;
	}

	//û���ҵ�
	return NULL;
}

//����ı���
void List::ScanList()
{
	Node *pTemp = g_pHead;
	while (pTemp != NULL)
	{
		printf("node.a=%d\n", pTemp->a);
		pTemp = pTemp->pNext;
	}
}

//ͷ�ڵ�����
void List::AddNodeToListHead(int a)
{
	//����һ���ڵ�
	Node *pTemp = (Node *)malloc(sizeof(Node));
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
void List::AddNodeToListTail(int a)
{
	//β���
	//����һ���ڵ�
	Node *pTmp = (Node *)malloc(sizeof(Node));

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

//����ռ��ͷ� -- ���
void List::FreeList()
{
	//������������
	Node *pTemp = g_pHead;
	while (g_pHead != NULL)
	{
		//ͷָ�����һ��
		g_pHead = g_pHead->pNext;
		free(pTemp);
		pTemp = g_pHead;
	}
	//βָ���λ���Ѿ��ͷ��ˣ����Ը�һ����ָ��Ϳ���
	//free(g_pEnd);
	g_pEnd = NULL;
}

//ͷɾ��
void List::DeleteListHead()
{
	if (g_pHead != NULL)
	{
		Node *pTmp = g_pHead;
		//����һ���ڵ���ͷ�ӵ���
		g_pHead = g_pHead->pNext;
		//�ͷ�ԭ�е�ͷ���
		free(pTmp);
	}
	else
	{
		printf("����Ϊ�գ��޷��ͷ�");
		return;
	}
}

//βɾ��
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
		////����Ѱ��β�ڵ��β�ڵ��ǰһ���ڵ��ָ��
		//struct Node *pTmpLeft = g_pHead;
		//struct Node *pTmpRight = g_pHead->pNext;
		//
		////β�ڵ��ָ��ָ����ǿ�
		//while (pTmpRight->pNext != NULL)
		//{
		//	pTmpRight = pTmpRight->pNext;
		//	pTmpLeft = pTmpLeft->pNext;
		//}
		//
		////����������β�ڵ�
		//g_pEnd = pTmpLeft;
		//g_pEnd->pNext = NULL;

		////�ͷ�ԭ��β�ڵ�
		//free(pTmpRight);

		//�Ż�
		Node *pTemp = g_pHead;
		while (pTemp->pNext != g_pEnd)
		{
			//�ҵ������ڶ����ڵ�
			pTemp = pTemp->pNext;
		}
		//�ͷ�ԭ����β�ڵ�
		free(g_pEnd);
		//��������β�ڵ�
		g_pEnd = pTemp;
		g_pEnd->pNext = NULL;
	}
	else
	{
		printf("����Ϊ�գ��޷��ͷ�");
		return;
	}
}

//ɾ��ָ���ڵ�
void List::DeleteListRand(int a)
{
	//�����ж�
	if (g_pHead == NULL)
	{
		printf("����Ϊ�գ��޷�ɾ��\n");
		return;
	}
	//����Ϊ�գ��ҵ�����ڵ�
	Node* pTemp = SelectList(a);
	if (pTemp == NULL)
	{
		printf("û������ڵ�\n");
		return;
	}

	//�ҵ�������ڵ�
	if (g_pHead == g_pEnd)
	{
		free(g_pHead);
		g_pHead = NULL;
		g_pEnd = NULL;
	}
	//�������ڵ�
	else if (g_pHead->pNext == g_pEnd)
	{
		//ɾ��ͷ�ڵ����β�ڵ�
		if (g_pHead == pTemp)
		{
			DeleteListHead();
		}
		else
		{
			DeleteListTail();
		}
	}
	else //�ж���ڵ�
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
			//�ڵ�����
			pTempLeft->pNext = pTemp->pNext;
			//�ͷ�pTemp
			pTemp->pNext = NULL;
			free(pTemp);
		}
	}
}