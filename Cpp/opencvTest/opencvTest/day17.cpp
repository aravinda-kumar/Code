//#include <iostream>
//#include <opencv2/opencv.hpp>
//using namespace std;
//using namespace cv;
//
//int main()
//{
//	Mat src, dst; 
//	src = imread("E:\\JZS\\MyComputer\\1_ѧУ\\�γ�\\ͼ����\\lena.png");
//	if (!src.data)
//	{
//		cout << "can not load the file......" << endl;
//		system("pause");
//		return -1;
//	}
//	namedWindow("ԭʼͼ��", CV_WINDOW_AUTOSIZE);
//	imshow("ԭʼͼ��", src);
//
//	//��˹ģ��ƽ��ȥ��
//	GaussianBlur(src, src, Size(3, 3), 0);
//	//��ͼ��ת��Ϊ�Ҷ�ͼ��
//	cvtColor(src, src, CV_BGR2GRAY);
//	imshow("�Ҷ�ͼ��", src);
//
//	Mat xgrad, ygrad;
//	Sobel(src, xgrad, CV_16S, 1, 0, 3);
//	Sobel(src, ygrad, CV_16S, 0, 1, 3);
//	//CV_16S���з��ŵģ���Ҫ��ȡ����ֵ
//	convertScaleAbs(xgrad, xgrad);
//	convertScaleAbs(ygrad, ygrad);
//	imshow("xgrad", xgrad);
//	imshow("ygrad", ygrad);
//
//	//������ͼƬ�����ں�
//	addWeighted(xgrad, 0.5, ygrad, 0.5, 0, dst);
//	imshow("���ͼ��", dst);
//
//	int key = waitKey(0);
//	return 0;
//}