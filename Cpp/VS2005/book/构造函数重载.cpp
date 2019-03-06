//#include <iostream>
//using namespace std;
//
//class box
//{
//public:
//	box();
//	box(int a):length(a)
//	{
//		height = 2;
//		width = 3;
//	}
//	box(int a,int b,int c):length(a),height(b),width(c){}
//	void show();
//private:
//	int length;
//	int height;
//	int width; 
//};
//
//box :: box()
//{
//	length = 1;
//	height = 2;
//	width = 3;
//}
//
//void box :: show()
//{
//	cout << "The out is:" << length*height*width <<endl;
//}
//
//int main()
//{
//	box b1;
//	b1.show();
//	box b2(3,4,5);
//	b2.show();
//	box b3(3);
//	b3.show();
//	system("pause");
//	return 0;
//}