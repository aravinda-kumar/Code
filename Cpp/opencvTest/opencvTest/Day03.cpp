//#include<opencv2\opencv.hpp>
//#include <iostream>
//using namespace std;
//using namespace cv;
//
//int main()
//{
//	//打开一张图片并显示
//	Mat src = imread("D:\\个人文档\\1_学校\\课程\\图像处理\\lena.png");
//	if (src.empty())
//	{
//		cout << "can not find the file..." << endl;
//		return -1;
//	}
//	namedWindow("input", CV_WINDOW_AUTOSIZE);
//	imshow("input", src);
//
//	//创建一个图片图像，并将尺寸类型同src，颜色设置为(127, 0, 255)
//	Mat dst;
//	dst = Mat(src.size(), src.type(), Scalar(127, 0, 255));
//	namedWindow("output", CV_WINDOW_AUTOSIZE);
//	imshow("output", dst);
//
//	//克隆一个src对象，并显示
//	Mat clone = src.clone();
//	namedWindow("clone", CV_WINDOW_AUTOSIZE);
//	imshow("clone", clone);
//
//	//创建一个小色块，并显示
//	Mat block = Mat(100, 100, CV_8UC3, Scalar(255, 0, 0));
//	//IO操作非常耗时间
//	//cout << "block = " << endl << block << endl;
//	namedWindow("block", CV_WINDOW_AUTOSIZE);
//	imshow("block", block);
//
//	//创建一个灰度图像并显示和原图的通道数对比
//	Mat gray;
//	cvtColor(src, gray, CV_BGR2GRAY);
//	namedWindow("gray", CV_WINDOW_AUTOSIZE);
//	imshow("gray", gray);
//	cout << "Channels of src = " << src.channels() << endl;
//	cout << "Channels of gray = " << gray.channels() << endl;
//
//	//获得图片特定位置的像素值
//	uchar* pos_src = src.ptr<uchar>(0);
//	uchar* pos_gray = gray.ptr<uchar>(0);
//	//显示数据的值要进行强制类型转换
//	cout << "The first pixel of src = " << (int)*pos_src << endl;
//	printf("The first pixel of src = %d\n", *pos_src);
//	cout << "The first pixel of gray = " << (int)*pos_gray<< endl;
//
//	//获取src的行和列
//	//行和列等于分辨率
//	int col = src.cols;
//	int row = src.rows;
//	cout << "col = " << col << endl << "row = " << row << endl;
//
//	//使用create创建
//	Mat cre;
//	cre.create(src.size(), src.type());
//	cre = Scalar(0, 0, 255);
//	namedWindow("cre", CV_WINDOW_AUTOSIZE);
//	imshow("cre", gray);
//
//	//创建小数组
//	Mat csrc = Mat::zeros(src.size(), src.type());
//	Mat kernel = (Mat_<float>(3, 3) << 0, -1, 0, -1, 5, -1, 0, -1, 0);
//	//掩膜操作增强对比度
//	filter2D(src, csrc, src.depth(), kernel);
//	namedWindow("csrc", CV_WINDOW_AUTOSIZE);
//	imshow("csrc", csrc);
//
//	//zeros数组，0矩阵
//	Mat zeros = Mat::zeros(3, 3, CV_8UC3);
//	cout << zeros << endl;
//
//	//eye数组，对角矩阵
//	Mat eye = Mat::eye(3, 3, CV_8UC3);
//	cout << eye << endl;
//
//
//	waitKey(0);
//	return 0;
//}