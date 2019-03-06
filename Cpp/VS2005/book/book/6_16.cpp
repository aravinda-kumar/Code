//#include <iostream>
//using namespace std;
//
//int main()
//{
//	char *p_str="a123x456  17960?302tab5876";
//	int i_a[20]={0};
//	int i_countx,i_count=0;
//	int i_num=0;
//	cout<< "str:" << p_str << endl;
//	
//	for(i_countx=0;i_countx<strlen(p_str)+1;i_countx++)
//	{
//		if(*(p_str+i_countx)>='0' && *(p_str+i_countx)<='9')
//		{
//			i_num = *(p_str+i_countx)-48+i_num*10;
//			cout << i_num << endl;
//		}
//		else
//		{	
//			cout << endl;
//			if(i_num!=0)
//			{
//				i_a[i_count++]=i_num;
//				i_num=0;
//			}
//		}
//	}
//	for(i_countx=0;i_countx<i_count;i_countx++)
//		cout << i_a[i_countx] << ' ';
//	cout << endl;
//
//	system("pause");
//	return 0;
//}