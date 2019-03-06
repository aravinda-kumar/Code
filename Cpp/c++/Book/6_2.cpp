//#include <iostream>
//#include <string>
//using namespace std;
//
//void sorted(string *s_str, int i_num);
//
//int main()
//{
//	string s_str[3];
//	int i_countx;
//	cout << "ÊäÈëÈı¸ö×Ö·û´®:" << endl;
//	for(i_countx=0;i_countx<3;i_countx++)
//		cin >> s_str[i_countx];
//	sorted(s_str, 3);
//	
//	cout << "ÅÅĞòÖ®ºóµÄ×Ö·û´®Ë³ĞòÊÇ£º" << endl;
//	for(i_countx=0;i_countx<3;i_countx++)
//		cout <<*(s_str+i_countx) << endl;
//
//	system("pause");
//	return 0;
//}
//
//void sorted(string *s_str, int i_num)
//{
//	int i_count,i_countx,i_county;
//	string s_tmp;
//
//	for(i_countx=0;i_countx<i_num-1;i_countx++)
//	{
//		i_count=i_countx;
//		for(i_county=i_countx+1;i_county<i_num;i_county++)
//			if(*(s_str+i_count) > *(s_str+i_county))
//				i_count = i_county;
//		if(i_count != i_countx)
//		{
//			s_tmp = *(s_str+i_count);
//			*(s_str+i_count) = *(s_str+i_countx);
//			*(s_str+i_countx) = s_tmp;
//		}
//	}
//}