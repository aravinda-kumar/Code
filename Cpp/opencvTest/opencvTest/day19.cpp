//#include <iostream>
//#include <opencv2/opencv.hpp>
//using namespace std;
//using namespace cv;
//
//
//Mat src, dst, gray_src;
//int t1_value = 60;
//int max_value = 255;
//
//void Canny_test(int, void*);
//
//int main()
//{
//	src = imread("E:\\JZS\\MyComputer\\1_学校\\课程\\图像处理\\lena.png");
//	if (!src.data)
//	{
//		cout << "can not load the file......" << endl;
//		return -1;
//	}
//	namedWindow("原始图像", CV_WINDOW_AUTOSIZE);
//	imshow("原始图像", src);
//
//	cvtColor(src, gray_src, CV_BGR2GRAY);
//	Canny_test(0, 0);
//	createTrackbar("Threshold value", "output", &t1_value, max_value, Canny_test);
//	
//
//	int key = waitKey(0);
//	return 0;
//}
//
//void Canny_test(int, void*)
//{
//	Mat edge_output;
//	GaussianBlur(gray_src, src, Size(3, 3), 0);
//	Canny(gray_src, edge_output, t1_value, t1_value * 2);
//
//	imshow("output", edge_output);
//}