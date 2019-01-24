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
//		cout << "cannot load the file..." << endl;
//		return -1;
//	}
//	namedWindow("原始图像", CV_WINDOW_AUTOSIZE);
//	imshow("原始图像", src);
//
//	//Mat xrobertdst, yrobertdst, robertdst;
//	////robert算子 x方向，y方向
//	//Mat xrobertkernel = (Mat_<int>(2, 2) << 1, 0, 0, -1);
//	//Mat yrobertkernel = (Mat_<int>(2, 2) << 0, 1, -1, 0);
//	//filter2D(src, xrobertdst, -1, xrobertkernel);
//	//filter2D(src, yrobertdst, -1, yrobertkernel);
//
//	//namedWindow("robertx", CV_WINDOW_AUTOSIZE);
//	//imshow("robertx", xrobertdst);
//	//namedWindow("roberty", CV_WINDOW_AUTOSIZE);
//	//imshow("roberty", yrobertdst);
//
//	//add(xrobertdst, yrobertdst, robertdst);
//	//namedWindow("robert", CV_WINDOW_AUTOSIZE);
//	//imshow("robert", robertdst);
//
//	////sobel算子
//	//Mat xsobeldst, ysobeldst, sobeldst;
//	////sobel算子 x方向，y方向
//	//Mat xsobelkernel = (Mat_<int>(3, 3) << -1, 0, 1, -2, 0, 2, -1, 0, 1);
//	//Mat ysobelkernel = (Mat_<int>(3, 3) << -1, -2, -1, 0, 0, 0, 1, 2, 1);
//	//filter2D(src, xsobeldst, -1, xsobelkernel);
//	//filter2D(src, ysobeldst, -1, ysobelkernel);
//
//	//namedWindow("sobelx", CV_WINDOW_AUTOSIZE);
//	//imshow("sobelx", xsobeldst);
//	//namedWindow("sobely", CV_WINDOW_AUTOSIZE);
//	//imshow("sobely", ysobeldst);
//
//	//add(xsobeldst, ysobeldst, sobeldst);
//	//namedWindow("sobel", CV_WINDOW_AUTOSIZE);
//	//imshow("sobel", sobeldst);
//
//	////laplace算子
//	//Mat laplacedst;
//	////laplace核
//	//Mat laplacekernel = (Mat_<int>(3, 3) << 0, -1, 0, -1, 4, -1, 0, -1, 0);
//	//filter2D(src, laplacedst, -1, laplacekernel);
//	//namedWindow("laplace", CV_WINDOW_AUTOSIZE);
//	//imshow("laplace", laplacedst);
//
//	//自定义卷积核
//	int c = 0;
//	int index = 0;
//	int ksize = 3;
//	while (true)
//	{
//		c = waitKey(500);
//		if ((char)c == 27)
//		{
//			//键盘的esc按键
//			break;
//		}
//		ksize = (index % 8) * 2 + 1;
//		Mat kernel = Mat::ones(Size(ksize, ksize), CV_32F) / (float)(ksize*ksize);
//		filter2D(src, dst, -1, kernel);
//		namedWindow("output", CV_WINDOW_AUTOSIZE);
//		imshow("output", dst);
//		index++;
//	}
//
//
//	//waitKey(0);
//	return 0;
//}