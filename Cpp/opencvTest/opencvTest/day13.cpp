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
//		cout << "cannot load the file..." << endl;
//		return -1;
//	}
//	namedWindow("原始图像", CV_WINDOW_AUTOSIZE);
//	imshow("原始图像", src);
//
//	//上采样
//	pyrUp(src, dst, Size(src.cols * 2, src.rows * 2));
//	namedWindow("上采样", CV_WINDOW_AUTOSIZE);
//	imshow("上采样", dst);
//
//	//下采样
//	Mat dstdown;
//	pyrDown(src, dstdown, Size(src.cols / 2, src.rows / 2));
//	namedWindow("下采样", CV_WINDOW_AUTOSIZE);
//	imshow("下采样", dstdown);
//
//	//DOG
//	Mat gray_src, g1, g2, dogimg;
//	cvtColor(src, gray_src, CV_BGR2GRAY);
//	GaussianBlur(gray_src, g1, Size(3, 3), 0);
//	GaussianBlur(g1, g2, Size(3, 3), 0);
//	subtract(g2, g1, dogimg, Mat());
//
//	//将像素值进行放大
//	normalize(dogimg, dogimg, 255, 0, NORM_MINMAX);
//
//	namedWindow("Dog", CV_WINDOW_AUTOSIZE);
//	imshow("Dog", dogimg);
//
//	waitKey(0);
//	return 0;
//}