#include "list.h"

int main()
{
	List list;
	list.AddNodeToListHead(1);
	list.AddNodeToListHead(2);
	list.AddNodeToListHead(3);
	list.AddNodeToListHead(4);
	list.AddNodeToListHead(5);
	list.AddNodeToListHead(6);
	list.AddNodeToListHead(7);

	list.ScanList();

	cout << "=========================" << endl;

	list.DeleteListRand(1);
	list.ScanList();

	system("pause");
	return 0;
}