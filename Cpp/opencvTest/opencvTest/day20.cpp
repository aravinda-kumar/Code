//#include <iostream>
//#include <opencv2/opencv.hpp>
//using namespace std;
//using namespace cv;
//
//int main()
//{
//	Mat src, dst;
//	src = imread("E:\\JZS\\Cpp_Demo\\OpenCVTest\\line.png");
//	if (src.empty())
//	{
//		cout << "cannot load the file......" << endl;
//		return -1;
//	}
//	namedWindow("原始图像", CV_WINDOW_AUTOSIZE);
//	imshow("原始图像", src);
//
//	Mat gray_src;
//	Canny(src, gray_src, 150, 200);
//	cvtColor(gray_src, dst, CV_GRAY2BGR);
//	imshow("edge", gray_src);
//
//	vector<Vec4f> plines;
//	HoughLinesP(gray_src, plines, 1, CV_PI / 180.0, 10, 0, 10);
//	Scalar color = Scalar(0, 0, 255);
//	for (size_t i = 0; i<plines.size(); i++)
//	{
//		Vec4f hline = plines[i];
//		//绘制图像只能在RGB图上绘制
//		line(dst, Point(hline[0], hline[1]), Point(hline[2], hline[3]), color, 3, LINE_AA);
//	}
//	
//	imshow("output", dst);
//	
//
//	int key = waitKey(0);
//	return 0;
//}