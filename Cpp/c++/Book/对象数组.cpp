//#include <iostream>
//using namespace std;
//
//class Box
//{
//public:
//	Box(int=10,int=10,int=10);
//	int volume();
//	~Box();
//private:
//	int length;
//	int width;
//	int height;
//};
//
//int main()
//{
//	Box	box[4]={
//		Box(),
//		Box(12),
//		Box(15,16),
//		Box(17,18,19)
//	};
//	
//	cout << "The volume of box1 is:" << box[0].volume() << endl;
//	cout << "The volume of box2 is:" << box[1].volume() << endl;
//	cout << "The volume of box3 is:" << box[2].volume() << endl;
//	cout << "The volume of box4 is:" << box[3].volume() << endl;
//
//	system("pause");
//	return 0;
//}
//
//Box::Box(int a, int b, int c)
//{
//	length = a;
//	width = b;
//	height =c;
//}
//
//int Box::volume()
//{
//	return height*length*width;
//}
//
//Box::~Box()
//{
//	cout << "Destructor called Done!" << endl;
//}