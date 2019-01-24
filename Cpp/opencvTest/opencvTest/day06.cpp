//#include <iostream>
//#include <opencv2\opencv.hpp>
//using namespace std;
//using namespace cv;
//
//int main()
//{
//	Mat src, dst;
//	src = imread("D:\\个人文档\\1_学校\\课程\\图像处理\\lena.png");
//	if (src.empty())
//	{
//		cout << "file does not exit()" << endl;
//		return -1;
//	}
//	namedWindow("原始图像", CV_WINDOW_AUTOSIZE);
//	imshow("原始图像", src);
//
//	int height = src.rows;
//	int width = src.cols;
//
//	//定义一个图像，类型尺寸同src
//	dst = Mat::zeros(src.size(), src.type());
//	
//	//将像素读出为vec3f，需要先进行一下的转换
//	Mat m1;
//	src.convertTo(m1, CV_32F);
//
//	//两个对比度的参数
//	double alpha = 1.5;
//	double beta = 10;
//
//	for (int row = 0; row < height; row++)
//	{
//		for (int col = 0; col < width; col++)
//		{
//			//判断图像的通道数
//
//			//src为RGB图像
//			if (src.channels()==3)
//			{
//				//先取出原图的三个通道的像素值
//				float b = m1.at<Vec3f>(row, col)[0];
//				float g = m1.at<Vec3f>(row, col)[1];
//				float r = m1.at<Vec3f>(row, col)[2];
//
//				//进行像素操作后复制给输出图像
//				dst.at<Vec3b>(row, col)[0] = saturate_cast<uchar>(b * alpha + beta);
//				dst.at<Vec3b>(row, col)[1] = saturate_cast<uchar>(g * alpha + beta);
//				dst.at<Vec3b>(row, col)[2] = saturate_cast<uchar>(r * alpha + beta);
//			}
//			else
//			{
//				//src为灰度图像
//				if (src.channels() == 1)
//				{
//					uchar v = src.at<uchar>(row, col);
//					dst.at<uchar>(row, col) = saturate_cast<uchar>(v*alpha + beta);
//				}
//			}
//		}
//	}
//
//	//结果图像输出
//	namedWindow("输出图像");
//	imshow("输出图像", dst);
//
//	waitKey(0);
//	return 0;
//}