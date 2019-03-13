#pragma once

#include<iostream>
#include<cstdio>
#include<cstdlib>
using namespace std;

//定义节点结构体
struct Node
{
	int a;					//数据成员
	Node *pNext;		//指向下一个节点的指针
};

class List
{
private:	
	Node *g_pHead = NULL;	//链表的头指针
	Node *g_pEnd = NULL;		//链表的尾指针

public:
	List();
	~List();

public:
	//头节点增加
	void AddNodeToListHead(int a);
	//创建链表，在链表中增加数据，尾添加
	void AddNodeToListTail(int a);
	//在指定位置添加节点
	void AddListRand(const unsigned int pos, Node *node);

public:
	//链表的遍历
	void ScanList();

public:
	//查询指定的节点
	Node* SelectList(int a);

public:
	//删除指定节点
	void DeleteListRand(int a);
	
private:
	//统计节点个数
	unsigned int CountList();
	//链表空间释放 -- 清空
	void FreeList();
	//头删除
	void DeleteListHead();
	//尾删除
	void DeleteListTail();
};