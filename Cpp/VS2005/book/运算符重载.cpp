//#include <iostream>
//using namespace std;
//
//class complex
//{
//public:
//	complex():rea(0),img(0){}
//	complex(float a,float b):rea(a),img(b){}
//	complex operator + (complex &t1);		//����complex Ϊ��������ֵ���� operator + Ϊ��������
//	void show();
//private:
//	float rea;
//	float img;
//};
//
//complex complex :: operator + (complex &t1)			//��һ��complexΪ����ֵ����  �ڶ���complexΪ��complex��
//{
//	complex c;
//	c.rea = t1.rea + rea;
//	c.img = t1.img + img;
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
//	t3 = t1 + t2;			//	�ȼ���t3 = t1.operator + (t2);
//	complex t4;
//	t4 = t1 + t2 + t3;
//	t1.show();
//	t2.show();
//	t3.show();
//	t4.show();
//	system("pause");
//	return 0;
//}