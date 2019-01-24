//#include <opencv2/opencv.hpp>
//#include <iostream>
//using namespace std;
//using namespace cv;
//
//int main()
//{
//	//读取一个图片并显示
//	Mat src = imread("D:\\个人文档\\1_学校\\课程\\图像处理\\lena.png");
//	namedWindow("原始图像", CV_WINDOW_AUTOSIZE);
//	imshow("原始图像", src);
//
//	//单通道操作像素
//	Mat gray_src;
//	cvtColor(src, gray_src, CV_BGR2GRAY);
//	namedWindow("灰度图像", CV_WINDOW_AUTOSIZE);
//	imshow("灰度图像", gray_src);
//
//	int rows = gray_src.rows;
//	int cols = gray_src.cols;
//	for (int row = 0; row < rows; row++)
//	{
//		for (int col=0;col<cols;col++)
//		{
//			//对灰度图像的每个像素取反
//			int gray = gray_src.at<uchar>(row, col);
//			gray_src.at<uchar>(row, col) = saturate_cast<uchar>(255-gray);
//		}
//	}
//	namedWindow("转换灰度图像", CV_WINDOW_AUTOSIZE);
//	imshow("转换灰度图像", gray_src);
//
//	//多通道操作像素
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
//	//按位取反，像素取反API
//	//bitwise_not(src, dst);
//
//	namedWindow("目标图像", CV_WINDOW_AUTOSIZE);
//	imshow("目标图像", dst);
//
//	waitKey(0);
//	return 0;
//}