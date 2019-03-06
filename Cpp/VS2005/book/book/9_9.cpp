//#include <iostream>
//using namespace std;
//
//class Sale
//{
//public:
//	Sale(int num, int quantity, double price);
//	void total();
//	// static只能引用static属性.
//	// 非static函数既可以引用static属性也可以引用非static属性.
//	static double average();
//private:
//	int num;
//	int quantity;
//	double price;
//	static double count;
//	static double sum;
//};
//
//int main()
//{
//	Sale s1[3]={Sale(101,5,23.5),Sale(102,12,24.56),Sale(103,100,21.5)};
//	int i_countx;
//	for(i_countx=0;i_countx<3;i_countx++)
//		s1[i_countx].total();
//	cout << "average=" << Sale::average();
//
//	system("pause");
//	return 0;
//}
//
//Sale::Sale(int num, int quantity, double price)
//{
//	this->num = num;
//	this->quantity = quantity;
//	this->price = price;
//}
//
//double Sale::count=0;
//double Sale::sum=0;
//
//void Sale::total()
//{
//	count += quantity;
//	sum += (quantity*price);
//}
//double Sale::average()
//{
//	return sum/count;
//}