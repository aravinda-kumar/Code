
#include"find.h"

//��ѯָ���Ľڵ�
struct Node* SelectList(int a)
{
	struct Node *pTemp = g_pHead;
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