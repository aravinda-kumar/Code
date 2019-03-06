//#include <iostream>
//#include <string>
//using namespace std;
//
//#define NUM 10
//
//struct Student
//{
//	int num;
//	string name;
//	int score[3];
//};
//
//int main()
//{
//	Student stu[NUM];
//	int i_countx,i_county,i_count;
//	int i_sum=0;
//	double d_average[NUM];
//	for(i_countx=0;i_countx<NUM;i_countx++)
//		cin >> stu[i_countx].num >> stu[i_countx].name >> stu[i_countx].score[0] >> stu[i_countx].score[1] >> stu[i_countx].score[2];
//	for(i_countx=0;i_countx<NUM;i_countx++)
//	{	for(i_county=0;i_county<3;i_county++)
//		{
//			i_sum += stu[i_countx].score[i_county];
//		}
//		d_average[i_countx]=i_sum/3;
//		i_sum=0;
//	}
//	i_count=0;
//	for(i_countx=1;i_countx<NUM;i_countx++)
//	{
//		if(d_average[i_count]<d_average[i_countx])
//			i_count=i_countx;
//	}
//	cout << stu[i_count].num << ' ' << stu[i_count].name << ' ' << stu[i_count].score[0] << ' ' << stu[i_count].score[1] << ' ' << stu[i_count].score[2] << ' ' << d_average[i_count] << endl;
//	system("pause");
//	return 0;
//}