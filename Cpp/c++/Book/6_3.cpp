//#include <iostream>
//using namespace std;
//
//void input_10(int *i_a, int i_num=10);
//void process_10(int *i_a, int i_num=10);
//void output_10(int *i_a, int i_num=10);
//
//int main()
//{
//	int i_a[10];
//	input_10(i_a);
//	process_10(i_a);
//	output_10(i_a);
//
//	system("pause");
//	return 0;
//}
//
//void input_10(int *i_a, int i_num)
//{
//	int i_countx;
//	cout << "请输入10个整数：" << endl;
//	for(i_countx=0;i_countx<i_num;i_countx++)
//		cin >> *(i_a+i_countx);
//}
//
//void process_10(int *i_a, int i_num)
//{
//	int i_countx;
//	int i_tmp;
//	int i_tmp_min, i_tmp_max;
//	i_tmp_min = i_tmp_max = 0;
//	for(i_countx=1;i_countx<i_num;i_countx++)
//	{
//		if(*(i_a+i_tmp_max)<*(i_a+i_countx))	i_tmp_max=i_countx;
//		if(*(i_a+i_tmp_min)>*(i_a+i_countx))	i_tmp_min=i_countx;
//	}
//	cout << "min=" << *(i_a+i_tmp_min) << endl;
//	cout << "max=" << *(i_a+i_tmp_max) << endl;
//	if(i_tmp_max==0 && i_tmp_min==i_num-1)
//	{
//		i_tmp=*(i_a+0); *(i_a+0)=*(i_a+i_tmp_min); *(i_a+i_tmp_min)=i_tmp;
//	}
//	else
//	{
//		i_tmp=*(i_a+0); *(i_a+0)=*(i_a+i_tmp_min); *(i_a+i_tmp_min)=i_tmp;
//		i_tmp=*(i_a+i_num-1); *(i_a+i_num-1)=*(i_a+i_tmp_max); *(i_a+i_tmp_max)=i_tmp;
//	}
//}
//
//void output_10(int *i_a, int i_num)
//{
//	int i_countx;
//	cout << "输出的10个数为：" << endl;
//	for(i_countx=0;i_countx<i_num;i_countx++)
//		cout << *(i_a+i_countx) << ' ';
//	cout << endl;
//}