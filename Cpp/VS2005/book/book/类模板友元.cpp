//#include<iostream>
//
//template<class T>
//class Test;
//template<class T>
//void print(const Test<T> &test);
//
//template<class T>
//class Test
//{
//private:
//	T m_x;
//
//public:
//	friend void print<T>(const Test<T> &test);//这里<T>必不可少
//	Test(T x) :m_x(x)
//	{
//	}
//};
//template<class T>
//void print(const Test<T> &test)
//{
//	std::cout << test.m_x<< std::endl;
//};
//int main()
//{
//	Test<int> test(1);
//	print(test);
//
//	std::cin.get();
//	return 0;
//}