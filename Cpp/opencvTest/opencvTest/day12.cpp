//#include <iostream>
//#include <opencv2/opencv.hpp>
//using namespace std;
//using namespace cv;
//
//int main()
//{
//	Mat src, dst;
//	src = imread("E:\\JZS\\MyComputer\\1_ѧУ\\�γ�\\ͼ����\\lena.png");
//	if (src.empty())
//	{
//		cout << "can not load the file..." << endl;
//		return -1;
//	}
//	namedWindow("ԭʼͼ��", CV_WINDOW_AUTOSIZE);
//	imshow("ԭʼͼ��", src);
//
//	Mat gray_src;
//	cvtColor(src, gray_src, CV_BGR2GRAY);
//	namedWindow("�Ҷ�ͼ��", CV_WINDOW_AUTOSIZE);
//	imshow("�Ҷ�ͼ��", gray_src);
//
//	Mat bin_src;
//	adaptiveThreshold(~gray_src, bin_src, 255, ADAPTIVE_THRESH_MEAN_C, THRESH_BINARY, 15, -2);
//	namedWindow("��ֵͼ��", CV_WINDOW_AUTOSIZE);
//	imshow("��ֵͼ��", bin_src);
//
//	Mat hLien = getStructuringElement(MORPH_RECT, Size(src.cols / 16, 1), Point(-1, -1));
//	Mat vLine = getStructuringElement(MORPH_RECT, Size(1, src.rows / 16), Point(-1, -1));
//
//	Mat tmp;
//	erode(bin_src, tmp, hLien);
//	dilate(tmp, dst, hLien);
//	bitwise_not(dst, dst);
//	namedWindow("ˮƽ��", CV_WINDOW_AUTOSIZE);
//	imshow("ˮƽ��", dst);
//
//	erode(bin_src, tmp, vLine);
//	dilate(tmp, dst, vLine);
//	bitwise_not(dst, dst);
//	namedWindow("��ֱ��", CV_WINDOW_AUTOSIZE);
//	imshow("��ֱ��", dst);
//
//	waitKey(0);
//	return 0;
//}