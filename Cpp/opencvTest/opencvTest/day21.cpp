#include <iostream>
#include <opencv2/opencv.hpp>
using namespace std;
using namespace cv;

int main()
{
	Mat src, dst;
	src = imread("E:\\JZS\\MyComputer\\1_学校\\课程\\图像处理\\lena.png");
	if (src.empty())
	{
		cout << "can not load the file......" << endl;
		return -1;
	}
	namedWindow("原始图像", CV_WINDOW_AUTOSIZE);
	imshow("原始图像", src);

	int key = waitKey(0);
	return 0;
}