//#include <opencv2/opencv.hpp>
//#include <iostream>
//
//using namespace std;
//using namespace cv;
//
//int main()
//{
//	//��ָ��·���¶���ͼƬ�����ҷ���һ��Mat����
//	Mat img = imread("D:\\�����ĵ�\\1_ѧУ\\�γ�\\ͼ����\\lena.png");
//
//	//�ж��ļ��Ƿ�Ϊ��
//	if (img.empty())
//	{	
//		cout << "can not find the image" << endl;
//		return -1;
//	}
//
//	//����һ�����ڣ���ʾԭͼ��
//	namedWindow("ԭͼ��", CV_WINDOW_AUTOSIZE);
//	imshow("ԭͼ��", img);
//
//	//����Mat���󣬲���ԭͼת���ɻҶ�ͼ
//	Mat outImage;
//	cvtColor(img, outImage, COLOR_RGB2GRAY);
//
//	//������һ�����ڣ���ʾ�Ҷ�ͼ��
//	namedWindow("���ͼ��", WINDOW_AUTOSIZE);
//	imshow("���ͼ��", outImage);
//
//	//�������ɵĻҶ�ͼ��
//	imwrite("D:\\�����ĵ�\\1_ѧУ\\�γ�\\ͼ����\\lenagray.png", outImage);
//
//	waitKey(0);
//	return 0;
//}