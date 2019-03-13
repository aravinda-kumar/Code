#pragma once

#include<iostream>
#include<cstdio>
#include<cstdlib>
using namespace std;

//����ڵ�ṹ��
struct Node
{
	int a;					//���ݳ�Ա
	Node *pNext;		//ָ����һ���ڵ��ָ��
};

class List
{
private:	
	Node *g_pHead = NULL;	//�����ͷָ��
	Node *g_pEnd = NULL;		//�����βָ��

public:
	List();
	~List();

public:
	//ͷ�ڵ�����
	void AddNodeToListHead(int a);
	//�����������������������ݣ�β���
	void AddNodeToListTail(int a);
	//��ָ��λ����ӽڵ�
	void AddListRand(const unsigned int pos, Node *node);

public:
	//����ı���
	void ScanList();

public:
	//��ѯָ���Ľڵ�
	Node* SelectList(int a);

public:
	//ɾ��ָ���ڵ�
	void DeleteListRand(int a);
	
private:
	//ͳ�ƽڵ����
	unsigned int CountList();
	//����ռ��ͷ� -- ���
	void FreeList();
	//ͷɾ��
	void DeleteListHead();
	//βɾ��
	void DeleteListTail();
};