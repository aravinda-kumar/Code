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
//		cout << "can not load the file......" << endl;
//		return -1;
//	}
//	namedWindow("ԭʼͼ��", CV_WINDOW_AUTOSIZE);
//	imshow("ԭʼͼ��", src);
//
//	Mat gray_src;
//	GaussianBlur(src, src, Size(3, 3), 0);
//	cvtColor(src, gray_src, CV_BGR2GRAY);
//
//	Laplacian(gray_src, dst, CV_16S, 3);
//	convertScaleAbs(dst, dst);
//	imshow("���ͼ��", dst);
//
//	threshold(dst, dst, 0, 255, THRESH_OTSU | THRESH_BINARY);
//	imshow("��ֵͼ��", dst);
//
//	int key = waitKey(0);
//	return 0;
//}