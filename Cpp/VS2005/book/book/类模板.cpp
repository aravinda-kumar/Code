//#include <iostream>
//#include <string>
//using namespace std;
//
//template<class numtype>
//class Compare
//{
//public:
//	Compare(numtype a, numtype b);
//	//{
//	//	this->a=a;
//	//	this->b=b;
//	//}
//	numtype max();
//	numtype min();
//private:
//	numtype a;
//	numtype b;
//};
//
//int main()
//{
//	Compare <int> c1(12,15);
//	Compare <double> c2(12.45, 12.46);
//	Compare <string> c3("zhu", "shuai");
//
//	cout << "c1.max=" << c1.max() << endl << "c1.min=" << c1.min() << endl;
//	cout << "c2.max=" << c2.max() << endl << "c2.min=" << c2.min() << endl;
//	cout << "c3.max=" << c3.max() << endl << "c3.min=" << c3.min() << endl;
//
//	system("pause");
//	return 0;
//}
//
//template<class numtype>
//Compare<numtype>::Compare(numtype a, numtype b)
//{
//	this->a=a;
//	this->b=b;
//}
//
//template<class numtype>
//numtype Compare<numtype>::max()
//{
//	return a>b?a:b;
//}
//
//template<class numtype>
//numtype Compare<numtype>::min()
//{
//	return a<b?a:b;
//}