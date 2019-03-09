//#include<iostream>
//using namespace std;
//
//template<typename T1, typename T2=int>
//class CFather
//{
//public:
//	T1 a;
//	CFather(T1 a)
//	{
//		this->a = 12;
//	}
//	void Show()
//	{
//		cout << a << endl;
//	}
//};
//
//template<typename T1, typename T2>	//此处可以不指定类型参数的默认值
//class CSon :public CFather<T1, T2>	//父类要指定参数列表
//{
//public:
//	CSon(T1 a):CFather<T1, T2>(a)	//构造处也要指定
//	{
//
//	}
//};
//
//int main()
//{
//	CSon<int, string> son(12);
//	son.Show();
//
//	CSon<int, int> *pson = new CSon<int, int>(123);
//	pson->Show();
//
//	system("pause");
//	return 0;
//}