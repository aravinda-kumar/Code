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
//		cout << "cannot load the file..." << endl;
//		return -1;
//	}
//	namedWindow("ԭʼͼ��", CV_WINDOW_AUTOSIZE);
//	imshow("ԭʼͼ��", src);
//	Mat kernel = getStructuringElement(MORPH_RECT, Size(3, 3), Point(-1, -1));
//	morphologyEx(src, dst, CV_MOP_BLACKHAT, kernel);
//	namedWindow("������", CV_WINDOW_AUTOSIZE);
//	imshow("������", dst);
//
//
//	waitKey(0);
//	return 0;
//}