//
//#include"insert.h"
//
////��ָ��λ����ӽڵ�
//void AddListRand(const unsigned int pos, struct Node *node)
//{
//	//����Ѱַ��ָ��,pos�����������ڵ�
//	struct Node *pTmpLeft = g_pHead;
//	struct NOde *pTmpRight = pTmpLeft;
//
//	//����ͳ���������еĽڵ���
//	unsigned int nCount = CountList();
//
//	//�����λ���ǵ�һ���ڵ�
//	if (pos == 1)
//	{
//		//��ͷ�ڵ����ϼ���
//		node->pNext = g_pHead;
//		g_pHead = node;
//	}
//	else if (pos >= nCount)
//	{
//		//����Ľڵ������β�ڵ����ϼ���
//		g_pEnd->pNext = node;
//		node->pNext = NULL;
//		g_pEnd = node;
//	}
//	else
//	{
//		//�����λ�����м�
//		//�ҵ����������������ڵ�
//		for (unsigned int i = 0; i < pos - 2; i++)
//		{
//			pTmpLeft = pTmpLeft->pNext;
//		}
//		
//		//�ڵ��������
//		pTmpRight = pTmpLeft->pNext;
//		pTmpLeft->pNext = node;
//		node->pNext = pTmpRight;
//	}
//
//}
//
//unsigned int CountList()
//{
//	//���ͷָ���ǿգ�û��Ԫ�أ�����0
//	if (g_pHead == NULL)
//	{
//		return 0;
//	}
//	//�ݴ�ͷָ��
//	struct Node *pTmp = g_pHead;
//	//ͳ�ƽڵ����
//	unsigned int nCount = 0;
//	while (pTmp != NULL)
//	{
//		nCount++;
//		pTmp = pTmp->pNext;
//	}
//	return nCount;
//}