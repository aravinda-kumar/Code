//#include"delete.h"
//
////����ռ��ͷ� -- ���
//void FreeList()
//{
//	//������������
//	struct Node *pTemp = g_pHead;
//	while (g_pHead != NULL)
//	{
//		//ͷָ�����һ��
//		g_pHead = g_pHead->pNext;
//		free(pTemp);
//		pTemp = g_pHead;
//	}
//	//βָ���λ���Ѿ��ͷ��ˣ����Ը�һ����ָ��Ϳ���
//	//free(g_pEnd);
//	g_pEnd = NULL;
//}
//
////ͷɾ��
//void DeleteListHead()
//{
//	if (g_pHead != NULL)
//	{
//		struct Node *pTmp = g_pHead;
//		//����һ���ڵ���ͷ�ӵ���
//		g_pHead = g_pHead->pNext;
//		//�ͷ�ԭ�е�ͷ���
//		free(pTmp);
//	}
//	else
//	{
//		printf("����Ϊ�գ��޷��ͷ�");
//		return;
//	}
//}
//
////βɾ��
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
//		////����Ѱ��β�ڵ��β�ڵ��ǰһ���ڵ��ָ��
//		//struct Node *pTmpLeft = g_pHead;
//		//struct Node *pTmpRight = g_pHead->pNext;
//		//
//		////β�ڵ��ָ��ָ����ǿ�
//		//while (pTmpRight->pNext != NULL)
//		//{
//		//	pTmpRight = pTmpRight->pNext;
//		//	pTmpLeft = pTmpLeft->pNext;
//		//}
//		//
//		////����������β�ڵ�
//		//g_pEnd = pTmpLeft;
//		//g_pEnd->pNext = NULL;
//
//		////�ͷ�ԭ��β�ڵ�
//		//free(pTmpRight);
//
//		//�Ż�
//		struct Node *pTemp = g_pHead;
//		while (pTemp->pNext != g_pEnd)
//		{
//			//�ҵ������ڶ����ڵ�
//			pTemp = pTemp->pNext;
//		}
//		//�ͷ�ԭ����β�ڵ�
//		free(g_pEnd);
//		//��������β�ڵ�
//		g_pEnd = pTemp;
//		g_pEnd->pNext = NULL;
//	}
//	else
//	{
//		printf("����Ϊ�գ��޷��ͷ�");
//		return;
//	}
//}
//
////ɾ��ָ���ڵ�
//void DeleteListRand(int a)
//{
//	//�����ж�
//	if (g_pHead == NULL)
//	{
//		printf("����Ϊ�գ��޷�ɾ��\n");
//		return;
//	}
//	//����Ϊ�գ��ҵ�����ڵ�
//	struct Node* pTemp = SelectList(a);
//	if (pTemp == NULL)
//	{
//		printf("û������ڵ�\n");
//		return;
//	}
//
//	//�ҵ�������ڵ�
//	if (g_pHead == g_pEnd)
//	{
//		free(g_pHead);
//		g_pHead = NULL;
//		g_pEnd = NULL;
//	}
//	//�������ڵ�
//	else if (g_pHead->pNext == g_pEnd)
//	{
//		//ɾ��ͷ�ڵ����β�ڵ�
//		if (g_pHead == pTemp)
//		{
//			DeleteListHead();
//		}
//		else
//		{
//			DeleteListTail();
//		}
//	}
//	else //�ж���ڵ�
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
//			//�ڵ�����
//			pTempLeft->pNext = pTemp->pNext;
//			//�ͷ�pTemp
//			pTemp->pNext = NULL;
//			free(pTemp);
//		}
//	}
//}