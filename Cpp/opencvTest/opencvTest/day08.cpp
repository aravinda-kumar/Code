//#include <iostream>
//#include <opencv2\opencv.hpp>
//using namespace std;
//using namespace cv;
//
//int main()
//{
//	Mat src = imread("D:\\�����ĵ�\\1_ѧУ\\�γ�\\ͼ����\\lena.png");;
//	if (src.empty())
//	{
//		cout << "can not load the file..." << endl;
//		return -1;
//	}
//	namedWindow("ԭͼ��", CV_WINDOW_AUTOSIZE);
//	imshow("ԭͼ��", src);
//
//	Mat dst = Mat::zeros(src.size(), src.type());
//	blur(src, dst, Size(5, 5));
//	namedWindow("��ֵģ��ͼ��", CV_WINDOW_AUTOSIZE);
//	imshow("��ֵģ��ͼ��", dst);
//
//	Mat dst2 = Mat::zeros(src.size(), src.type());
//	GaussianBlur(src, dst2, Size(3, 3), 1.0);
//	namedWindow("��˹ģ��ͼ��", CV_WINDOW_AUTOSIZE);
//	imshow("��˹ģ��ͼ��", dst2);
//
//	waitKey(0);
//	return 0;
//}