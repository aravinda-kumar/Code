#include<stdio.h>
#include<stdlib.h>

//����ڵ�ṹ��
struct Node
{
	int a;					//���ݳ�Ա
	struct Node *pNext;		//ָ����һ���ڵ��ָ��
};

//ͷβָ�붨��
struct Node *g_pHead;
struct Node *g_pEnd = NULL;

//β���
void AddListTail(int a);

//ͷ���
void AddListHead(int a);

//��ͷ�����ʼ��
void InitList();

//�����ڵ㺯��
struct Node* CreateNode(int a);

int main(void)
{
	//�����ͷ��ʼ��
	InitList();

	//����
	AddListHead(5);
	AddListHead(21);
	AddListHead(14);
	AddListHead(112);
	AddListHead(0);

	system("pause");
	return 0;
}

//β���
void AddListTail(int a)
{
	struct Node *pTmp = CreateNode(a);

	//����
	g_pEnd->pNext = pTmp;
	g_pEnd = pTmp;
}

//ͷ���
void AddListHead(int a)
{
	//����ռ�
	struct Node *pTmp = CreateNode(a);

	//���ӽڵ�
	pTmp->pNext = g_pHead;
	g_pHead = pTmp;
}

//��ͷ�����ʼ��
void InitList()
{
	//�����ͷ
	g_pHead = (struct Node *)malloc(sizeof(struct Node));
	g_pHead->pNext = NULL;
	g_pEnd = g_pHead;
}

//�����ڵ㺯��
struct Node* CreateNode(int a)
{
	//����һ���ڵ�
	struct Node *pTmp = (struct Node *)malloc(sizeof(struct Node));

	if (NULL == pTmp)
	{
		printf("�ռ�����ʧ��");
		return NULL;
	}

	//�ڵ��Ա��ֵ
	pTmp->a = a;
	pTmp->pNext = NULL;

	return pTmp;
}