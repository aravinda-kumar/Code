//#include <opencv2/opencv.hpp>
//#include <iostream>
//
//using namespace std;
//using namespace cv;
//
//int main()
//{
//	Mat src, dst;
//	src = imread("D:\\�����ĵ�\\1_ѧУ\\�γ�\\ͼ����\\lena.png");
//	if (!src.data)
//	{
//		cout << "can not find a file" << endl;
//	}
//	else
//	{
//		//ʵ����dst����
//		//src.copyTo(dst);
//		dst = Mat::zeros(src.size(), src.type());
//
//		//��ʾͼ��
//		namedWindow("ԭͼ��", CV_WINDOW_AUTOSIZE);
//		imshow("ԭͼ��", src);
//
//		//һ��ͼ���ͨ������N���ͱ���ÿ�����ص㴦��N����
//		//һ��a��b��Nͨ��ͼ����ͼ�����ʵ������b��N��a�е����־���
//		//��ʽΪ	RGBRGBRGBRGBRGBRGB
//		//ͼƬ����
//		int cols = (src.cols-1)*src.channels();
//		//ͼƬ����
//		int rows = src.rows;
//		//��ȡͨ����������ƫ����
//		int offsetx = src.channels();
//		/*
//		kernel  = [0 -1 0\
//						-1 5 -1\
//						0 -1 0]
//		*/
//		double t = getTickCount();
//		//3x3�ĺˣ�����ȥ����һ�к����һ��
//		for (int row = 1; row < (rows - 1); row++)
//		{
//			//��ȡ��ǰ�У���һ�к���һ�е�ͼ��ָ��
//			const uchar* current = src.ptr<uchar>(row);
//			const uchar* previous = src.ptr<uchar>(row - 1);
//			const uchar* next = src.ptr<uchar>(row + 1);
//
//			//��ȡ���ͼ��ĵ�ǰ�е�ͼ��ָ��
//			uchar* output = dst.ptr<uchar>(row);
//
//			//����RGB�����з�ʽ��Ҫ�ӵڶ���ͨ������ʼλ��ʼִ��
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
//		//��ʾͼ��
//		namedWindow("��Ĥͼ��", CV_WINDOW_AUTOSIZE);
//		imshow("��Ĥͼ��", dst);
//	}
//
//	waitKey(0);
//	return 0;
//}