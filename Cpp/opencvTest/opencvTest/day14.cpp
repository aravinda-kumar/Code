//#include <iostream>
//#include <opencv2/opencv.hpp>
//using namespace std;
//using namespace cv;
//
//Mat src, dst, gray_src;
//int threshold_value = 127;
//int threshold_max = 255;
//const char* output_title = "binary image";
//void Threshold_Demo(int, void*);
//
//int main()
//{
//	src = imread("E:\\JZS\\MyComputer\\1_ѧУ\\�γ�\\ͼ����\\lena.png");
//	if (src.empty())
//	{
//		cout << "error" << endl;
//		return -1;
//	}
//	namedWindow("ԭʼͼ��", CV_WINDOW_AUTOSIZE);
//	imshow("ԭʼͼ��", src);
//
//	Threshold_Demo(0, 0);
//	createTrackbar("Threshold Value:", output_title, &threshold_value, threshold_max, Threshold_Demo);
//
//	waitKey(0);
//	return 0;
//}
//
//void Threshold_Demo(int, void*)
//{
//	cvtColor(src, gray_src, CV_BGR2GRAY);
//	threshold(gray_src, dst, threshold_value, threshold_max, THRESH_BINARY_INV);
//	imshow(output_title, dst);
//}