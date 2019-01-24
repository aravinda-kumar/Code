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
//	src = imread("D:\\个人文档\\1_学校\\课程\\图像处理\\lena.png", IMREAD_GRAYSCALE);
//	if (src.empty())
//	{
//		cout << "cannot load the file..." << endl;
//		return -1;
//	}
//	namedWindow("原始图像", CV_WINDOW_AUTOSIZE);
//	imshow("原始图像", src);
//
//	namedWindow("输出图像", CV_WINDOW_AUTOSIZE);
//	
//	//在图片窗口上显示一个拖拽条
//	createTrackbar("Element Size", "输出图像", &element_size, max_size, CallBack_Demo);
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
//	imshow("输出图像", dst);
//}