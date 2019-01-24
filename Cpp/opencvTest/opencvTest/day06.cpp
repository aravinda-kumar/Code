//#include <iostream>
//#include <opencv2\opencv.hpp>
//using namespace std;
//using namespace cv;
//
//int main()
//{
//	Mat src, dst;
//	src = imread("D:\\�����ĵ�\\1_ѧУ\\�γ�\\ͼ����\\lena.png");
//	if (src.empty())
//	{
//		cout << "file does not exit()" << endl;
//		return -1;
//	}
//	namedWindow("ԭʼͼ��", CV_WINDOW_AUTOSIZE);
//	imshow("ԭʼͼ��", src);
//
//	int height = src.rows;
//	int width = src.cols;
//
//	//����һ��ͼ�����ͳߴ�ͬsrc
//	dst = Mat::zeros(src.size(), src.type());
//	
//	//�����ض���Ϊvec3f����Ҫ�Ƚ���һ�µ�ת��
//	Mat m1;
//	src.convertTo(m1, CV_32F);
//
//	//�����ԱȶȵĲ���
//	double alpha = 1.5;
//	double beta = 10;
//
//	for (int row = 0; row < height; row++)
//	{
//		for (int col = 0; col < width; col++)
//		{
//			//�ж�ͼ���ͨ����
//
//			//srcΪRGBͼ��
//			if (src.channels()==3)
//			{
//				//��ȡ��ԭͼ������ͨ��������ֵ
//				float b = m1.at<Vec3f>(row, col)[0];
//				float g = m1.at<Vec3f>(row, col)[1];
//				float r = m1.at<Vec3f>(row, col)[2];
//
//				//�������ز������Ƹ����ͼ��
//				dst.at<Vec3b>(row, col)[0] = saturate_cast<uchar>(b * alpha + beta);
//				dst.at<Vec3b>(row, col)[1] = saturate_cast<uchar>(g * alpha + beta);
//				dst.at<Vec3b>(row, col)[2] = saturate_cast<uchar>(r * alpha + beta);
//			}
//			else
//			{
//				//srcΪ�Ҷ�ͼ��
//				if (src.channels() == 1)
//				{
//					uchar v = src.at<uchar>(row, col);
//					dst.at<uchar>(row, col) = saturate_cast<uchar>(v*alpha + beta);
//				}
//			}
//		}
//	}
//
//	//���ͼ�����
//	namedWindow("���ͼ��");
//	imshow("���ͼ��", dst);
//
//	waitKey(0);
//	return 0;
//}