//#include <iostream>
//#include <opencv2/opencv.hpp>
//using namespace std;
//using namespace cv;
//
//int main()
//{
//	Mat src;
//	src = imread("D:\\个人文档\\1_学校\\课程\\图像处理\\lena.png");
//	if (src.empty())
//	{
//		cout << "can not load the file..." << endl;
//		return -1;
//	}
//	namedWindow("原始图像", CV_WINDOW_AUTOSIZE);
//	imshow("原始图像", src);
//
//	Mat dstMeidaBlur = Mat::zeros(src.size(), src.type());
//	medianBlur(src, dstMeidaBlur, 3);
//	namedWindow("中值滤波", CV_WINDOW_AUTOSIZE);
//	imshow("中值滤波", dstMeidaBlur);
//
//
//	Mat dst2d = Mat::zeros(src.size(), src.type());
//	Mat kernel = (Mat_<int>(3, 3) << 0, -1, 0, -1, 5, -1, 0, -1, 0);
//	filter2D(src, dst2d, -1, kernel);
//	namedWindow("filter2D", CV_WINDOW_AUTOSIZE);
//	imshow("filter2D", dst2d);
//
//	Mat dstBi = Mat::zeros(src.size(), src.type());
//	bilateralFilter(dst2d, dstBi, 15, 150, 3);
//	namedWindow("双边滤波", CV_WINDOW_AUTOSIZE);
//	imshow("双边滤波", dstBi);
//
//	waitKey(0);
//	return 0;
//}