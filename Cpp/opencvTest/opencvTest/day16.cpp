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
//		cout << "cannot load the file......" << endl;
//		return -1;
//	}
//	namedWindow("原始图像", CV_WINDOW_AUTOSIZE);
//	imshow("原始图像", src);
//
//	int top = (int)(0.05*src.rows);
//	int bottom = (int)(0.05*src.rows);
//	int left = (int)(0.05*src.cols);
//	int right = (int)(0.05*src.cols);
//
//	RNG rng(12345);
//	int borderType = BORDER_DEFAULT;
//
//	int c = 0;
//	while (true)
//	{
//		c = waitKey(500);
//		if ((char)c == 27)
//		{
//			//按下esc
//			break;
//		}
//		else if ((char)c == 'r')
//		{
//			borderType = BORDER_REPLICATE;
//		}
//		else if ((char)c == 'w')
//		{
//			borderType = BORDER_WRAP;
//		}
//		else if ((char)c == 'c')
//		{
//			borderType = BORDER_CONSTANT;
//		}
//		else
//		{
//			borderType = BORDER_DEFAULT;
//		}
//		Scalar color = Scalar(rng.uniform(0, 255), rng.uniform(0, 255), rng.uniform(0, 255));
//		copyMakeBorder(src, dst, top, bottom, left, right, borderType, color);
//		namedWindow("output", CV_WINDOW_AUTOSIZE);
//		imshow("output", dst);
//	}
//
//
//	//int key = waitKey(0);
//	return 0;
//}