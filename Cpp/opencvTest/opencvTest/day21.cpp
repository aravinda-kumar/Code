#include <iostream>
#include <opencv2/opencv.hpp>
using namespace std;
using namespace cv;

int main()
{
	Mat src, dst;
	src = imread("E:\\JZS\\MyComputer\\1_ѧУ\\�γ�\\ͼ����\\lena.png");
	if (src.empty())
	{
		cout << "can not load the file......" << endl;
		return -1;
	}
	namedWindow("ԭʼͼ��", CV_WINDOW_AUTOSIZE);
	imshow("ԭʼͼ��", src);

	int key = waitKey(0);
	return 0;
}