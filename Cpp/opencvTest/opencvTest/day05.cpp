//#include <opencv2/opencv.hpp>
//#include <iostream>
//using namespace std;
//using namespace cv;
//
//int main()
//{
//	Mat src1, src2, dst;
//	src1 = imread("D:\\个人文档\\1_学校\\课程\\图像处理\\lena.png");
//	src2 = imread("D:\\个人文档\\1_学校\\课程\\图像处理\\signal.png");
//	if (src1.empty() || !src2.data)
//	{
//		cout << "file does not exit" << endl;
//		return -1;
//	}
//	namedWindow("lena", CV_WINDOW_AUTOSIZE);
//	namedWindow("signal", CV_WINDOW_AUTOSIZE);
//	imshow("lena",src1);
//	imshow("signal", src2);
//
//	//判断两张图片是否大小类型一样
//	if (src1.rows == src2.rows && src1.cols == src2.cols && src1.type() == src2.type())
//	{
//		addWeighted(src1, 0.5, src2, 0.5, 0.0, dst);
//		//add(src1, src2, dst, Mat());
//		//multiply(src1, src2, dst);
//		namedWindow("output");
//		imshow("output", dst);
//	}
//
//	waitKey(0);
//	return 0;
//}