//#include <iostream>
//#include <opencv2\opencv.hpp>
//using namespace std;
//using namespace cv;
//
//int main()
//{
//	Mat src = imread("D:\\个人文档\\1_学校\\课程\\图像处理\\lena.png");;
//	if (src.empty())
//	{
//		cout << "can not load the file..." << endl;
//		return -1;
//	}
//	namedWindow("原图像", CV_WINDOW_AUTOSIZE);
//	imshow("原图像", src);
//
//	Mat dst = Mat::zeros(src.size(), src.type());
//	blur(src, dst, Size(5, 5));
//	namedWindow("均值模糊图像", CV_WINDOW_AUTOSIZE);
//	imshow("均值模糊图像", dst);
//
//	Mat dst2 = Mat::zeros(src.size(), src.type());
//	GaussianBlur(src, dst2, Size(3, 3), 1.0);
//	namedWindow("高斯模糊图像", CV_WINDOW_AUTOSIZE);
//	imshow("高斯模糊图像", dst2);
//
//	waitKey(0);
//	return 0;
//}