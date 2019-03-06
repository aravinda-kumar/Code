//#include <iostream>
//using namespace std;
//
//int strcmp(char *p1, char *p2);
//
//int main()
//{
//	char c_ch1[10]="BOY";
//	char c_ch2[10]="BOY";
//	
//	cout << strcmp(c_ch1,c_ch2) << endl;
//
//	system("pause");
//	return 0;
//}
//
//int strcmp(char *p1, char *p2)
//{
//	int i_result;
//	int i_countx,i_county;
//	for(i_countx=0,i_county=0;*(p1+i_countx)!='\0' || *(p2+i_county)!='\0';i_countx++,i_county++)
//	{
//		i_result=*(p1+i_countx)-*(p2+i_county);
//		if(i_result!=0)
//			break;
//	}
//	if(i_result!=0)
//		return i_result;
//	else
//		return 0;
//}