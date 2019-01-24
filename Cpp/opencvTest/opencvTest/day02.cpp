//#include <opencv2/opencv.hpp>
//#include <iostream>
//
//using namespace std;
//using namespace cv;
//
//int main()
//{
//	Mat src, dst;
//	src = imread("D:\\个人文档\\1_学校\\课程\\图像处理\\lena.png");
//	if (!src.data)
//	{
//		cout << "can not find a file" << endl;
//	}
//	else
//	{
//		//实例化dst对象
//		//src.copyTo(dst);
//		dst = Mat::zeros(src.size(), src.type());
//
//		//显示图像
//		namedWindow("原图像", CV_WINDOW_AUTOSIZE);
//		imshow("原图像", src);
//
//		//一个图像的通道数是N，就表明每个像素点处有N个数
//		//一个a×b的N通道图像，其图像矩阵实际上是b行N×a列的数字矩阵。
//		//格式为	RGBRGBRGBRGBRGBRGB
//		//图片的列
//		int cols = (src.cols-1)*src.channels();
//		//图片的行
//		int rows = src.rows;
//		//获取通道数，设置偏移量
//		int offsetx = src.channels();
//		/*
//		kernel  = [0 -1 0\
//						-1 5 -1\
//						0 -1 0]
//		*/
//		double t = getTickCount();
//		//3x3的核，所以去掉第一行和最后一行
//		for (int row = 1; row < (rows - 1); row++)
//		{
//			//获取当前行，上一行和下一行的图像指针
//			const uchar* current = src.ptr<uchar>(row);
//			const uchar* previous = src.ptr<uchar>(row - 1);
//			const uchar* next = src.ptr<uchar>(row + 1);
//
//			//获取输出图像的当前行的图像指针
//			uchar* output = dst.ptr<uchar>(row);
//
//			//根据RGB的排列方式，要从第二个通道的起始位开始执行
//			for (int col = offsetx; col< cols; col++)
//			{
//				output[col] = saturate_cast<uchar>(5 * current[col] 
//																			- previous[col] 
//																			- next[col] 
//																			- current[col - offsetx] 
//																			- current[col + offsetx]);
//			}
//		}
//		double timeConsume = (getTickCount() - t) / getTickFrequency();
//		cout << timeConsume << endl;
//
//		//Mat kernel = (Mat_<char>(3, 3) << 0, -1, 0, -1, 5, -1, 0, -1, 0);
//		//filter2D(src, dst, src.depth(), kernel);
//
//		//显示图像
//		namedWindow("掩膜图像", CV_WINDOW_AUTOSIZE);
//		imshow("掩膜图像", dst);
//	}
//
//	waitKey(0);
//	return 0;
//}