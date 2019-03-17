//#include<iostream>
//using namespace std;
//
//int main()
//{
//	int a[10] = { 1,7,432,5,5,92,314,0,9,65 };
//	int b[10] = { 1,7,432,5,5,92,314,0,9,65 };
//
//	//´«Í³Ã°ÅÝÅÅÐò
//	int tmp;
//	int aCount = 0;
//	for (int i = 0; i < 8; i++)
//	{
//		for (int j = 0; j < 9; j++)
//		{
//			aCount++;
//			if (a[j] < a[j + 1])
//			{
//				tmp = a[j];
//				a[j] = a[j + 1];
//				a[j + 1] = tmp;
//			}
//		}
//	}
//	//72´ÎÅÅÐò
//	cout << "count = " << aCount << endl;
//	for (int i = 0; i < 10; i++)
//	{
//		cout << a[i] << ' ';
//	}
//	cout << endl;
//
//	//ÒÀ¿¿±êÖ¾Î»µÄÃ°ÅÝÅÅÐò
//	int bCount = 0;
//	bool isSorted = false;
//
//	while (!isSorted)
//	{
//		
//		isSorted = true;
//		for (int i = 0; i < 9; i++)
//		{
//			if (b[i] < b[i + 1])
//			{
//				bCount++;
//				isSorted = false;
//				tmp = b[i];
//				b[i] = b[i + 1];
//				b[i + 1] = tmp;
//			}
//		}
//	}
//	//26´ÎÅÅÐò
//	cout << "count = " << bCount << endl;
//	for (int i = 0; i < 10; i++)
//	{
//		cout << b[i] << ' ';
//	}
//	cout << endl;
//	system("pause");
//	return 0;
//}