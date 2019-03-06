//#include <iostream>
//using namespace std;
//
//typedef struct
//{
//	int year;
//	int month;
//	int day;
//}DATA;
//
//int days(DATA data);
//
//int main()
//{
//	DATA data;
//	int count;
//	while (1)
//	{
//		cout << "输入年月日：";
//		cin >> data.year >> data.month >> data.day;
//		if(data.year==0)
//			break; 
//		count = days(data);
//		cout << "No." << count << "day" << endl;
//	}
//	
//
//	system("pause");
//	return 0;
//}
//
//int days(DATA data)
//{
//	int result=0;
//	int month1=0;
//	int month2=month1+31;
//	int month3=month2+28;
//	int month4=month3+31;
//	int month5=month4+30;
//	int month6=month5+31;
//	int month7=month6+30;
//	int month8=month7+31;
//	int month9=month8+31;
//	int month10=month9+30;
//	int month11=month10+31;
//	int month12=month11+30;
//	switch(data.month)
//	{
//		case 1: result = month1 + data.day;break;
//		case 2: result = month2 + data.day;break;
//		case 3: result = month3 + data.day;break;
//		case 4: result = month4 + data.day;break;
//		case 5: result = month5 + data.day;break;
//		case 6: result = month6 + data.day;break;
//		case 7: result = month7 + data.day;break;
//		case 8: result = month8 + data.day;break;
//		case 9: result = month9 + data.day;break;
//		case 10: result = month10 + data.day;break;
//		case 11: result = month11 + data.day;break;
//		case 12: result = month12 + data.day;break;
//	}
//	if(data.year%400==0 || (data.year%4==0&&data.year%100!=0))
//		result += 1;
//	return result;
//}