//#include<opencv2\opencv.hpp>
//#include <iostream>
//using namespace std;
//using namespace cv;
//
//int main()
//{
//	//��һ��ͼƬ����ʾ
//	Mat src = imread("D:\\�����ĵ�\\1_ѧУ\\�γ�\\ͼ����\\lena.png");
//	if (src.empty())
//	{
//		cout << "can not find the file..." << endl;
//		return -1;
//	}
//	namedWindow("input", CV_WINDOW_AUTOSIZE);
//	imshow("input", src);
//
//	//����һ��ͼƬͼ�񣬲����ߴ�����ͬsrc����ɫ����Ϊ(127, 0, 255)
//	Mat dst;
//	dst = Mat(src.size(), src.type(), Scalar(127, 0, 255));
//	namedWindow("output", CV_WINDOW_AUTOSIZE);
//	imshow("output", dst);
//
//	//��¡һ��src���󣬲���ʾ
//	Mat clone = src.clone();
//	namedWindow("clone", CV_WINDOW_AUTOSIZE);
//	imshow("clone", clone);
//
//	//����һ��Сɫ�飬����ʾ
//	Mat block = Mat(100, 100, CV_8UC3, Scalar(255, 0, 0));
//	//IO�����ǳ���ʱ��
//	//cout << "block = " << endl << block << endl;
//	namedWindow("block", CV_WINDOW_AUTOSIZE);
//	imshow("block", block);
//
//	//����һ���Ҷ�ͼ����ʾ��ԭͼ��ͨ�����Ա�
//	Mat gray;
//	cvtColor(src, gray, CV_BGR2GRAY);
//	namedWindow("gray", CV_WINDOW_AUTOSIZE);
//	imshow("gray", gray);
//	cout << "Channels of src = " << src.channels() << endl;
//	cout << "Channels of gray = " << gray.channels() << endl;
//
//	//���ͼƬ�ض�λ�õ�����ֵ
//	uchar* pos_src = src.ptr<uchar>(0);
//	uchar* pos_gray = gray.ptr<uchar>(0);
//	//��ʾ���ݵ�ֵҪ����ǿ������ת��
//	cout << "The first pixel of src = " << (int)*pos_src << endl;
//	printf("The first pixel of src = %d\n", *pos_src);
//	cout << "The first pixel of gray = " << (int)*pos_gray<< endl;
//
//	//��ȡsrc���к���
//	//�к��е��ڷֱ���
//	int col = src.cols;
//	int row = src.rows;
//	cout << "col = " << col << endl << "row = " << row << endl;
//
//	//ʹ��create����
//	Mat cre;
//	cre.create(src.size(), src.type());
//	cre = Scalar(0, 0, 255);
//	namedWindow("cre", CV_WINDOW_AUTOSIZE);
//	imshow("cre", gray);
//
//	//����С����
//	Mat csrc = Mat::zeros(src.size(), src.type());
//	Mat kernel = (Mat_<float>(3, 3) << 0, -1, 0, -1, 5, -1, 0, -1, 0);
//	//��Ĥ������ǿ�Աȶ�
//	filter2D(src, csrc, src.depth(), kernel);
//	namedWindow("csrc", CV_WINDOW_AUTOSIZE);
//	imshow("csrc", csrc);
//
//	//zeros���飬0����
//	Mat zeros = Mat::zeros(3, 3, CV_8UC3);
//	cout << zeros << endl;
//
//	//eye���飬�ԽǾ���
//	Mat eye = Mat::eye(3, 3, CV_8UC3);
//	cout << eye << endl;
//
//
//	waitKey(0);
//	return 0;
//}