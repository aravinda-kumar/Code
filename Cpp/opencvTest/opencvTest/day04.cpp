//#include <opencv2/opencv.hpp>
//#include <iostream>
//using namespace std;
//using namespace cv;
//
//int main()
//{
//	//��ȡһ��ͼƬ����ʾ
//	Mat src = imread("D:\\�����ĵ�\\1_ѧУ\\�γ�\\ͼ����\\lena.png");
//	namedWindow("ԭʼͼ��", CV_WINDOW_AUTOSIZE);
//	imshow("ԭʼͼ��", src);
//
//	//��ͨ����������
//	Mat gray_src;
//	cvtColor(src, gray_src, CV_BGR2GRAY);
//	namedWindow("�Ҷ�ͼ��", CV_WINDOW_AUTOSIZE);
//	imshow("�Ҷ�ͼ��", gray_src);
//
//	int rows = gray_src.rows;
//	int cols = gray_src.cols;
//	for (int row = 0; row < rows; row++)
//	{
//		for (int col=0;col<cols;col++)
//		{
//			//�ԻҶ�ͼ���ÿ������ȡ��
//			int gray = gray_src.at<uchar>(row, col);
//			gray_src.at<uchar>(row, col) = saturate_cast<uchar>(255-gray);
//		}
//	}
//	namedWindow("ת���Ҷ�ͼ��", CV_WINDOW_AUTOSIZE);
//	imshow("ת���Ҷ�ͼ��", gray_src);
//
//	//��ͨ����������
//	Mat dst;
//	dst.create(src.size(), src.type());
//	int heights = dst.rows;
//	int widths = dst.cols;
//	int channel = dst.channels();
//	for (int height = 0; height < heights; height++)
//	{
//		for (int width=0;width<widths;width++)
//		{
//			if (channel==3)
//			{
//				//auto var_src = src.at<Vec3b>(height, width);
//				//auto var_dst = dst.at<Vec3b>(height, width);
//				//var_dst.val[0] = var_src.val[0];
//				//var_dst.val[1] = var_src.val[1];
//				//var_dst.val[2] = var_src.val[2];
//				dst.at<Vec3b>(height, width).val[0] = src.at<Vec3b>(height, width).val[0];
//				dst.at<Vec3b>(height, width).val[1] = src.at<Vec3b>(height, width).val[1];
//				dst.at<Vec3b>(height, width).val[2] = src.at<Vec3b>(height, width).val[2];
//			}
//		}
//	}
//
//	//��λȡ��������ȡ��API
//	//bitwise_not(src, dst);
//
//	namedWindow("Ŀ��ͼ��", CV_WINDOW_AUTOSIZE);
//	imshow("Ŀ��ͼ��", dst);
//
//	waitKey(0);
//	return 0;
//}