//#include<iostream>
//using namespace std;
//
//void sorted_country_name(char c_country_name[][20], int i_num);
//
//int main()
//{
//	char c_country_name[][20]={{"GERMANY"},{"FRANCH"},{"CHINA"}};
//	sorted_country_name(c_country_name, 3);
//	int i_num;
//	for (i_num=0;i_num<3;i_num++)
//		cout << c_country_name[i_num] << endl;
//	system("pause");
//	return 0;
//}
//
//void sorted_country_name(char c_country_name[][20], int i_num)
//{
//	char c_tmp[20];
//	int i_tmp_1, i_tmp_2;
//	for(i_tmp_1=0;i_tmp_1<i_num;i_tmp_1++)
//	{
//		for(i_tmp_2=0;i_tmp_2<i_num-1;i_tmp_2++)
//		{
//			if(strcmp(c_country_name[i_tmp_2],c_country_name[i_tmp_2+1])>0)
//			{
//				strcpy(c_tmp,c_country_name[i_tmp_2]);
//				strcpy(c_country_name[i_tmp_2],c_country_name[i_tmp_2+1]);
//				strcpy(c_country_name[i_tmp_2+1],c_tmp);
//			}
//		}
//	}
//}