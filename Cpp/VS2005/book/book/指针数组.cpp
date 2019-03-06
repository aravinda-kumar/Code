//#include <iostream>
//using namespace std;
//
//int main()
//{
//	char *cp_ch[5]={"BASIC","FORTRAN","C++","Pascal","COBOL"};
//	char *cp_tmp;
//	int i_countx,i_county;
//	int i_count;
//	
//	for(i_countx=0;i_countx<4;i_countx++)
//	{
//		i_count=i_countx;
//		cout << i_countx << endl;
//		for(i_county=i_countx+1;i_county<5;i_county++)
//			if(strcmp(cp_ch[i_count],cp_ch[i_county])>0)
//				i_count=i_county;
//		if(i_count!=i_countx)
//		{
//			cp_tmp=cp_ch[i_count];
//			cp_ch[i_count]=cp_ch[i_countx];
//			cp_ch[i_countx]=cp_tmp;
//		}
//	}
//
//	for(i_countx=0;i_countx<5;i_countx++)
//		cout << cp_ch[i_countx] << endl;
//	cout << strcmp("C++","COBOL") << endl;
//	system("pause");
//	return 0;
//}