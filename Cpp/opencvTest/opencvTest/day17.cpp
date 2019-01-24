//#include <iostream>
//#include <opencv2/opencv.hpp>
//using namespace std;
//using namespace cv;
//
//int main()
//{
//	Mat src, dst; 
//	src = imread("E:\\JZS\\MyComputer\\1_学校\\课程\\图像处理\\lena.png");
//	if (!src.data)
//	{
//		cout << "can not load the file......" << endl;
//		system("pause");
//		return -1;
//	}
//	namedWindow("原始图像", CV_WINDOW_AUTOSIZE);
//	imshow("原始图像", src);
//
//	//高斯模糊平滑去燥
//	GaussianBlur(src, src, Size(3, 3), 0);
//	//将图像转换为灰度图像
//	cvtColor(src, src, CV_BGR2GRAY);
//	imshow("灰度图像", src);
//
//	Mat xgrad, ygrad;
//	Sobel(src, xgrad, CV_16S, 1, 0, 3);
//	Sobel(src, ygrad, CV_16S, 0, 1, 3);
//	//CV_16S是有符号的，需要求取绝对值
//	convertScaleAbs(xgrad, xgrad);
//	convertScaleAbs(ygrad, ygrad);
//	imshow("xgrad", xgrad);
//	imshow("ygrad", ygrad);
//
//	//将两张图片进行融合
//	addWeighted(xgrad, 0.5, ygrad, 0.5, 0, dst);
//	imshow("结果图像", dst);
//
//	int key = waitKey(0);
//	return 0;
//}