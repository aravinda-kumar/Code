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
//	bgImage = imread("D:\\�����ĵ�\\1_ѧУ\\�γ�\\ͼ����\\lena.png");
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
////����ֱ��
//void MyLines()
//{
//	//����ȷ��һ��ֱ��
//	Point p1 = Point(20, 30);
//	Point p2;
//	p2.x = 200;
//	p2.y = 300;
//	//�������ֱ�ߵ���ɫ
//	Scalar color = Scalar(0, 0, 255);
//
//	//����������ͼƬ����ʼ�㣬�����㣬��ɫ���ߴ磬�߿����
//	line(bgImage, p1, p2, color, 1, LINE_AA);
//}
//
////���ƾ���
//void MyRectangle()
//{
//	//������ɫ
//	Scalar color = Scalar(255, 0, 0);
//	//������Σ�λ��x��λ��y������
//	Rect rect = Rect(200, 100, 300, 300);
//	//���������������Σ���ɫ���߿��ߵ�����
//	rectangle(bgImage, rect, color, 2, LINE_8);
//}
//
////������Բ
//void MyEllipse()
//{
//	//������ɫ
//	Scalar color = Scalar(0, 0, 255);
//	//���������������ĵ㣬ʵ������᳤��ƫ�ǣ���ʼ�Ƕȣ������Ƕȣ���ɫ���߿��ߵ�����
//	ellipse(bgImage, Point(bgImage.cols / 2, bgImage.rows / 2), Size(bgImage.cols / 4, bgImage.rows / 8), 0, 0, 360, color, 1, LINE_8);
//}
//
////����Բ��
//void MyCircle()
//{
//	//������ɫ
//	Scalar color = Scalar(0, 255, 255);
//	//���������������ĵ㣬�뾶���߿��ߵ�����
//	circle(bgImage, Point(bgImage.cols / 2, bgImage.rows / 2), 100, color, 10);
//}
//
////�������
//void MyPloygon()
//{
//	//����һ����ά���������������ĸ���
//	Point pts[1][5];
//	pts[0][0] = Point(100, 100);
//	pts[0][1] = Point(100, 200);
//	pts[0][2] = Point(200, 200);
//	pts[0][3] = Point(200, 100);
//	pts[0][4] = Point(100, 100);
//
//	//�ĸ���ĵ�һ�����ָ��
//	const Point* ppts[] = { pts[0] };
//
//	//��ĸ���
//	int npt[] = { 5 };
//
//	//������ɫ
//	Scalar color = Scalar(255, 0, 12);
//
//	//���������������������ĸ����ָ�룬��ĸ������߿���ɫ���ߵ�����
//	fillPoly(bgImage, ppts, npt, 1, color, LINE_8);
//}
//
//
////�������
//void RandomLineDemo()
//{
//	//�����µ�ͼ��
//	Mat bg = Mat::zeros(bgImage.size(), bgImage.type());
//	
//	//�涨����������ֵ
//	RNG rng(12345);
//	Point pt1, pt2;
//	for (int i=0;i<100000;i++)
//	{
//		//����һ��ָ����Χ��������������߽�
//		pt1.x = rng.uniform(0, bgImage.cols);
//		pt2.x = rng.uniform(0, bgImage.cols);
//
//		pt1.y = rng.uniform(0, bgImage.rows);
//		pt2.y = rng.uniform(0, bgImage.rows);
//
//		//���������ɫ
//		Scalar color = Scalar(rng.uniform(0, 255), rng.uniform(0, 255), rng.uniform(0, 255));
//
//		line(bg, pt1, pt2, color, 1);
//
//		//����ѭ��������
//		if (waitKey(50)>0)
//		{
//			break;
//		}
//		namedWindow("random line demo", CV_WINDOW_AUTOSIZE);
//		imshow("random line demo", bg);
//	}
//}