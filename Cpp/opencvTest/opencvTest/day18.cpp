//#include <iostream>
//#include <opencv2/opencv.hpp>
//using namespace std;
//using namespace cv;
//
//int main()
//{
//	Mat src, dst;
//	src = imread("E:\\JZS\\MyComputer\\1_学校\\课程\\图像处理\\lena.png");
//	if (src.empty())
//	{
//		cout << "can not load the file......" << endl;
//		return -1;
//	}
//	namedWindow("原始图像", CV_WINDOW_AUTOSIZE);
//	imshow("原始图像", src);
//
//	Mat gray_src;
//	GaussianBlur(src, src, Size(3, 3), 0);
//	cvtColor(src, gray_src, CV_BGR2GRAY);
//
//	Laplacian(gray_src, dst, CV_16S, 3);
//	convertScaleAbs(dst, dst);
//	imshow("输出图像", dst);
//
//	threshold(dst, dst, 0, 255, THRESH_OTSU | THRESH_BINARY);
//	imshow("二值图像", dst);
//
//	int key = waitKey(0);
//	return 0;
//}