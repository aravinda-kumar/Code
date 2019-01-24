//#include <opencv2/opencv.hpp>
//#include <iostream>
//
//using namespace std;
//using namespace cv;
//
//int main()
//{
//	//从指定路径下读出图片，并且返回一个Mat对象
//	Mat img = imread("D:\\个人文档\\1_学校\\课程\\图像处理\\lena.png");
//
//	//判断文件是否为空
//	if (img.empty())
//	{	
//		cout << "can not find the image" << endl;
//		return -1;
//	}
//
//	//创建一个窗口，显示原图像
//	namedWindow("原图像", CV_WINDOW_AUTOSIZE);
//	imshow("原图像", img);
//
//	//定义Mat对象，并将原图转换成灰度图
//	Mat outImage;
//	cvtColor(img, outImage, COLOR_RGB2GRAY);
//
//	//创建另一个窗口，显示灰度图像
//	namedWindow("输出图像", WINDOW_AUTOSIZE);
//	imshow("输出图像", outImage);
//
//	//保存生成的灰度图像
//	imwrite("D:\\个人文档\\1_学校\\课程\\图像处理\\lenagray.png", outImage);
//
//	waitKey(0);
//	return 0;
//}