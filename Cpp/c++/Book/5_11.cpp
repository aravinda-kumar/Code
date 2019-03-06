//#include <iostream>
//#include <string>
//using namespace std;
//
//int main()
//{
//	char c_star[5][9];
//	int i_countx,i_county;
//	for(i_countx=0;i_countx<5;i_countx++)
//	{
//		for(i_county=0;i_county<i_countx+5;i_county++)
//		{
//			if(i_county<i_countx)	c_star[i_countx][i_county]=' ';
//			else	c_star[i_countx][i_county]='*';
//		}
//	}
//	for(i_countx=0;i_countx<5;i_countx++)
//	{
//		for(i_county=0;i_county<i_countx+5;i_county++)
//		{
//			cout << c_star[i_countx][i_county];
//		}
//		cout << endl;
//	}
//
//	cout << "**********************************************" << endl;
//
//	string s_star[5];
//	for (i_countx=0;i_countx<5;i_countx++)
//	{
//		for(i_county=0;i_county<i_countx+5;i_county++)
//		{
//			if(i_county<i_countx)	s_star[i_countx].append(" ");
//			else	s_star[i_countx].append("*");
//		}
//	}
//	for(i_countx=0;i_countx<5;i_countx++)
//		cout << s_star[i_countx] << endl;
//
//	system("pause");
//	return 0;
//}