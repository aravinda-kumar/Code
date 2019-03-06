//#include <iostream>
//using namespace std;
//
//class box
//{
//public:
//	box(int a= 1,int b = 1,int c = 1):length(a),height(b),width(c){}
//	int figure()
//	{
//		return length*height*width;
//	}
//private:
//	int length;
//	int height;
//	int width;
//};
//
//int main()
//{
//	box b1(1,2,3);
//	box b2;
//	cout << "b1:" << b1.figure() << endl;
//	b2 = b1;
//	cout << "b2:" << b2.figure() << endl;
//	box b3(4,5,6),b4 = b3;
//	cout << "b3:" << b3.figure() << endl;
//	cout << "b4:" << b4.figure() << endl;
//	box b5(b3);
//	cout << "b5:" << b5.figure() << endl;
//	system("pause");
//	return 0;
//}