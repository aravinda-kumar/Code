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
//
//	//�ϲ���
//	pyrUp(src, dst, Size(src.cols * 2, src.rows * 2));
//	namedWindow("�ϲ���", CV_WINDOW_AUTOSIZE);
//	imshow("�ϲ���", dst);
//
//	//�²���
//	Mat dstdown;
//	pyrDown(src, dstdown, Size(src.cols / 2, src.rows / 2));
//	namedWindow("�²���", CV_WINDOW_AUTOSIZE);
//	imshow("�²���", dstdown);
//
//	//DOG
//	Mat gray_src, g1, g2, dogimg;
//	cvtColor(src, gray_src, CV_BGR2GRAY);
//	GaussianBlur(gray_src, g1, Size(3, 3), 0);
//	GaussianBlur(g1, g2, Size(3, 3), 0);
//	subtract(g2, g1, dogimg, Mat());
//
//	//������ֵ���зŴ�
//	normalize(dogimg, dogimg, 255, 0, NORM_MINMAX);
//
//	namedWindow("Dog", CV_WINDOW_AUTOSIZE);
//	imshow("Dog", dogimg);
//
//	waitKey(0);
//	return 0;
//}