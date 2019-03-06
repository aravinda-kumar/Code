//#include<iostream>
//using namespace std;
//
//void sort(char* name[], int n)
//{
//	int k;
//	int i,j;
//	char* tmp;
//	for(i=0;i<n-1;i++)
//	{
//		k = i;
//		for(j=i+1;j<n;j++)
//		{
//			if(strcmp(name[k],name[j])>0) k = j;
//			if(k != i)
//			{
//				tmp = name[k]; name[k] = name[i]; name[i] = tmp;
//			}
//		}
//	}
//}
//
//int main()
//{
//	char* name[]={"BASIC","FORTRAN","C++","Pascal","COBAL"};
//	int n;
//	n=5;
//	int i;
//	sort(name, 5);
//	for(i=0;i<5;i++)
//	{
//		cout << name[i] << endl;
//	}
//	system("pause");
//	return 0;
//}