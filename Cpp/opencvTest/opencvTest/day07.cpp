//#include <iostream>
//#include <opencv2/opencv.hpp>
//#include <imgproc.hpp>
//using namespace std;
//using namespace cv;
//
//Mat bgImage;
//const char* drawdemo_win = "Draw shapes and text demo";
//
//void MyLines();
//void MyRectangle();
//void MyEllipse();
//void MyCircle();
//void MyPloygon();
//void RandomLineDemo();
//
//int main()
//{
//	bgImage = imread("D:\\个人文档\\1_学校\\课程\\图像处理\\lena.png");
//	if (!bgImage.data)
//	{
//		cout << "cannot load a file" << endl;
//		return -1;
//	}
//	//MyLines();
//	//MyRectangle();
//	//MyEllipse();
//	//MyCircle();
//	//MyPloygon();
//
//	//putText(bgImage, "hello World", Point(200, 300), CV_FONT_HERSHEY_COMPLEX, 1.0, Scalar(120, 12, 255), 5);
//
//	RandomLineDemo();
//
//	//namedWindow(drawdemo_win, CV_WINDOW_AUTOSIZE);
//	//imshow(drawdemo_win, bgImage);
//
//	waitKey(0);
//	return 0;
//}
//
////绘制直线
//void MyLines()
//{
//	//两点确定一条直线
//	Point p1 = Point(20, 30);
//	Point p2;
//	p2.x = 200;
//	p2.y = 300;
//	//定义绘制直线的颜色
//	Scalar color = Scalar(0, 0, 255);
//
//	//参数：背景图片，起始点，结束点，颜色，尺寸，线抗锯齿
//	line(bgImage, p1, p2, color, 1, LINE_AA);
//}
//
////绘制矩形
//void MyRectangle()
//{
//	//定义颜色
//	Scalar color = Scalar(255, 0, 0);
//	//定义矩形，位置x，位置y，宽，高
//	Rect rect = Rect(200, 100, 300, 300);
//	//参数：背景，矩形，颜色，线宽，线的特质
//	rectangle(bgImage, rect, color, 2, LINE_8);
//}
//
////绘制椭圆
//void MyEllipse()
//{
//	//定义颜色
//	Scalar color = Scalar(0, 0, 255);
//	//参数：背景，中心点，实轴和虚轴长，偏角，起始角度，结束角度，颜色，线宽，线的特质
//	ellipse(bgImage, Point(bgImage.cols / 2, bgImage.rows / 2), Size(bgImage.cols / 4, bgImage.rows / 8), 0, 0, 360, color, 1, LINE_8);
//}
//
////绘制圆形
//void MyCircle()
//{
//	//定义颜色
//	Scalar color = Scalar(0, 255, 255);
//	//参数：背景，中心点，半径，线宽，线的特质
//	circle(bgImage, Point(bgImage.cols / 2, bgImage.rows / 2), 100, color, 10);
//}
//
////填充区域
//void MyPloygon()
//{
//	//定义一个二维矩阵存放填充区域的四个点
//	Point pts[1][5];
//	pts[0][0] = Point(100, 100);
//	pts[0][1] = Point(100, 200);
//	pts[0][2] = Point(200, 200);
//	pts[0][3] = Point(200, 100);
//	pts[0][4] = Point(100, 100);
//
//	//四个点的第一个点的指针
//	const Point* ppts[] = { pts[0] };
//
//	//点的个数
//	int npt[] = { 5 };
//
//	//定义颜色
//	Scalar color = Scalar(255, 0, 12);
//
//	//参数：背景，填充区域的四个点的指针，点的个数，线宽，颜色，线的特质
//	fillPoly(bgImage, ppts, npt, 1, color, LINE_8);
//}
//
//
////随机画线
//void RandomLineDemo()
//{
//	//定义新的图像
//	Mat bg = Mat::zeros(bgImage.size(), bgImage.type());
//	
//	//规定随机数的最大值
//	RNG rng(12345);
//	Point pt1, pt2;
//	for (int i=0;i<100000;i++)
//	{
//		//生成一个指定范围的随机数，包含边界
//		pt1.x = rng.uniform(0, bgImage.cols);
//		pt2.x = rng.uniform(0, bgImage.cols);
//
//		pt1.y = rng.uniform(0, bgImage.rows);
//		pt2.y = rng.uniform(0, bgImage.rows);
//
//		//随机生成颜色
//		Scalar color = Scalar(rng.uniform(0, 255), rng.uniform(0, 255), rng.uniform(0, 255));
//
//		line(bg, pt1, pt2, color, 1);
//
//		//跳出循环的条件
//		if (waitKey(50)>0)
//		{
//			break;
//		}
//		namedWindow("random line demo", CV_WINDOW_AUTOSIZE);
//		imshow("random line demo", bg);
//	}
//}