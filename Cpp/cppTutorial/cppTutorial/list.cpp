//#include<iostream>
//#include<list>
//#include<algorithm>
//using namespace std;
//
//struct Node
//{
//	int m;	//初始化0
//	char c; //初始化'\0'
//	Node(int _m, char _c)
//	{
//		this->m = _m;
//		c = _c;
//	}
//
//};
//
//bool operator == (Node &node1, const Node &node2)
//{
//	if (node2.m == node1.m && node2.c == node1.c)
//		return true;
//	return false;
//}
//
//bool operator < (Node &node1, const Node &node2)
//{
//	if (node2.m < node1.m)
//		return true;
//	if(node2.m == node1.m)
//		if (node2.c < node1.c)
//			return true;
//	return false;
//}
//
//void fun(Node node)
//{
//	cout << node.m << ' ' << node.c << '\n';
//}
////
////void ListDefine()
////{
////	list<Node> ls(5);
////	
////	Node node(12, 'a');
////	list<Node> ls1(6, node);
////
////	list<Node> ls2(ls1);
////	//cout << ls.size() << endl;
////	for_each(ls2.begin(), ls2.end(), fun);
////}
////
////void ListSize()
////{
////	Node node(12, 'a');
////	list<Node> ls(6, node);
////
////	for_each(ls.begin(), ls.end(), fun);
////	cout << ls.size() << endl;
////
////	cout << "=======================" << endl;
////
////	ls.resize(3);
////	for_each(ls.begin(), ls.end(), fun);
////	cout << ls.size() << endl;
////
////	cout << "=======================" << endl;
////	cout << ls.empty() << endl;
////	ls.clear();
////	cout << ls.size() << endl;
////	cout << ls.empty() << endl;
////}
//
//void ListCoutAdd()
//{
//	//Node node = { 12, 'a' };
//	//list<Node> ls(6, node);
//
//	////定义迭代器，循环输出链表
//	//list<Node>::iterator ite;
//	//for (ite = ls.begin(); ite != ls.end(); ite++)
//	//{
//	//	cout << ite->c << ' ' << ite->m << endl;
//	//}
//
//	//cout << "=======================" << endl;
//
//	////输出最后一个元素
//	//cout << ls.back().c << ' ' << ls.back().m << endl;
//
//	////输出第一个元素
//	//cout << ls.front().c << ' ' << ls.front().m << endl;
//	list<Node> ls;
//	ls.push_front(Node(12, 'a'));
//	ls.push_front(Node(13, 'b'));
//	ls.push_back(Node(14, 'z'));
//	for_each(ls.begin(), ls.end(), fun);
//
//	cout << "=======================" << endl;
//
//	list<Node>::iterator ite = ls.begin();
//	ite++;
//	ls.insert(ite, Node(18, 'm'));
//	for_each(ls.begin(), ls.end(), fun);
//
//	cout << "=======================" << endl;
//
//	ite = ls.begin();
//	ite++;
//	ite++; 
//	ls.insert(ite, 3, Node(11, 't'));
//	for_each(ls.begin(), ls.end(), fun);
//}
//
//void ListDeleteChange()
//{
//	list<Node> ls;
//	ls.push_front(Node(12, 'a'));
//	ls.push_front(Node(13, 'b'));
//	ls.push_front(Node(15, 'd'));
//	ls.push_front(Node(15, 'd'));
//	ls.push_front(Node(16, 'e'));
//	//for_each(ls.begin(), ls.end(), fun);
//	
//	cout << "=======================" << endl;
//
//	list<Node>::iterator ite = find(ls.begin(), ls.end(), Node(13, 'f'));
//	cout << ite->c << ' ' << ite->m << endl;
//
//	//ls.sort();
//	//for_each(ls.begin(), ls.end(), fun);
//
//	//ls.pop_back();
//	//for_each(ls.begin(), ls.end(), fun);
//
//	//cout << "=======================" << endl;
//
//	//ls.pop_front();
//	//for_each(ls.begin(), ls.end(), fun);
//	//ls.remove(Node(14, 'c'));
//	//for_each(ls.begin(), ls.end(), fun);
//
//	//cout << "=======================" << endl;
//	//ls.unique();
//	//for_each(ls.begin(), ls.end(), fun);
//}
//
//int main()
//{
//	ListDeleteChange();
//
//
//	system("pause");
//	return 0;
//}