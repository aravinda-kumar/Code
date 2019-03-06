//#include <iostream>
//using namespace std;
//
//int main()
//{
//	double f_interest, f_bonus;
//	int i_level;
//
//	cout << "Please input your interest:" << endl;
//	cin >> f_interest;
//	i_level = int(f_interest) / 100000;
//	
//	switch (i_level)
//	{
//		case 0: f_bonus = f_interest*0.1;break;
//		case 1: f_bonus = (f_interest-100000)*0.075+100000*0.1;break;
//		case 2: 
//		case 3: f_bonus = (f_interest-200000)*0.05+(200000-100000)*0.075+100000*0.1;break;
//		case 4: 
//		case 5: f_bonus = (f_interest-400000)*0.03+(400000-200000)*0.05+(200000-100000)*0.075+100000*0.1;break;
//		case 6:
//		case 7:
//		case 8:
//		case 9: f_bonus = (f_interest-600000)*0.015+(600000-400000)*0.03+(400000-200000)*0.05+(200000-100000)*0.075+100000*0.1;break;
//		default: f_bonus = (f_interest-1000000)*0.01+(1000000-600000)*0.015+(600000-400000)*0.03+(400000-200000)*0.05+(200000-100000)*0.075+100000*0.1;break;
//	}
//	cout << "The bonus is:" << f_bonus << endl;
//
//	system("pause");
//	return 0;
//}