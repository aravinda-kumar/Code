//#include<iostream>
//#include<opencv2\opencv.hpp>
//using namespace std;
//using namespace cv;
//
//Mat src;
//Mat dst;
//int element_size = 3;
//int max_size = 21;
//
//void	CallBack_Demo(int, void*);
//
//int main()
//{
//	src = imread("D:\\�����ĵ�\\1_ѧУ\\�γ�\\ͼ����\\lena.png", IMREAD_GRAYSCALE);
//	if (src.empty())
//	{
//		cout << "cannot load the file..." << endl;
//		return -1;
//	}
//	namedWindow("ԭʼͼ��", CV_WINDOW_AUTOSIZE);
//	imshow("ԭʼͼ��", src);
//
//	namedWindow("���ͼ��", CV_WINDOW_AUTOSIZE);
//	
//	//��ͼƬ��������ʾһ����ק��
//	createTrackbar("Element Size", "���ͼ��", &element_size, max_size, CallBack_Demo);
//	CallBack_Demo(0, 0);
//
//	waitKey(0);
//	return 0;
//}
//
//void	CallBack_Demo(int, void*)
//{
//	int s = element_size * 2 + 1;
//	Mat structureElement = getStructuringElement(MORPH_RECT, Size(s, s));
//	dilate(src, dst, structureElement);
//	//erode(src, dst, structureElement);
//	imshow("���ͼ��", dst);
//}