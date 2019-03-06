//#include <iostream>
//using namespace std;
//
//class complex
//{
//public:
//	complex():rea(0),img(0){}
//	complex(float a,float b):rea(a),img(b){}
//	friend complex operator + (complex t1,complex t2);		//其中complex 为函数返回值类型 operator + 为函数名；
//	friend complex operator + (float &t1,complex t2);	
//	void show();
//private:
//	float rea;
//	float img;
//};
//
//complex operator + (complex t1,complex t2)			//第一个complex为返回值类型  第二个complex为类complex；
//{
//	complex c;
//	c.rea = t1.rea + t2.rea;
//	c.img = t1.img + t2.img;
//	return c;
//}
//
//complex operator + (float &t1,complex t2)			//第一个complex为返回值类型  第二个complex为类complex；
//{
//	complex c;
//	c.rea = t1 + t2.rea;
//	c.img = t2.img;
//	return c;
//}
//
//void complex :: show()
//{
//	cout << "(" << rea << "+" << img << "i" << ")" << endl;
//}
//
//int main()
//{
//	complex t1(1,2),t2(3,4),t3;
//	t3 = t1 + t2;			//	等价于t3 = t1.operator + (t2);
//	complex t4;
//	t4 = t1 + t2 + t3;
//	t1.show();
//	cout << "**************************" << endl;
//	t2.show();
//	t3.show();
//	t4.show();
//	float t5 = 3;
//	t2 = t5 + t2;			//顺序和定义一致 正确；
////  t2 = t2 + t5;			  顺序和定义相反 错误；
//	t2.show();
//	system("pause");
//	return 0;
//}