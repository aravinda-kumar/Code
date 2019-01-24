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
//		cout << "can not load the file..." << endl;
//		return -1;
//	}
//	namedWindow("原始图像", CV_WINDOW_AUTOSIZE);
//	imshow("原始图像", src);
//
//	Mat gray_src;
//	cvtColor(src, gray_src, CV_BGR2GRAY);
//	namedWindow("灰度图像", CV_WINDOW_AUTOSIZE);
//	imshow("灰度图像", gray_src);
//
//	Mat bin_src;
//	adaptiveThreshold(~gray_src, bin_src, 255, ADAPTIVE_THRESH_MEAN_C, THRESH_BINARY, 15, -2);
//	namedWindow("二值图像", CV_WINDOW_AUTOSIZE);
//	imshow("二值图像", bin_src);
//
//	Mat hLien = getStructuringElement(MORPH_RECT, Size(src.cols / 16, 1), Point(-1, -1));
//	Mat vLine = getStructuringElement(MORPH_RECT, Size(1, src.rows / 16), Point(-1, -1));
//
//	Mat tmp;
//	erode(bin_src, tmp, hLien);
//	dilate(tmp, dst, hLien);
//	bitwise_not(dst, dst);
//	namedWindow("水平线", CV_WINDOW_AUTOSIZE);
//	imshow("水平线", dst);
//
//	erode(bin_src, tmp, vLine);
//	dilate(tmp, dst, vLine);
//	bitwise_not(dst, dst);
//	namedWindow("垂直线", CV_WINDOW_AUTOSIZE);
//	imshow("垂直线", dst);
//
//	waitKey(0);
//	return 0;
//}