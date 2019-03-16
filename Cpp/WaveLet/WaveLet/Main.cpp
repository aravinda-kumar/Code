#include <opencv2\imgproc\imgproc.hpp>
#include <opencv2\highgui\highgui.hpp>
#include <opencv2\core\core.hpp>
#include <iostream>
#include <math.h>
using namespace cv;
using namespace std;

Mat WDT(const Mat &_src, const string _wname, const int _level);
Mat IWDT(const Mat &_src, const string _wname, const int _level);
void wavelet(const string _wname, Mat &_lowFilter, Mat &_highFilter);
Mat waveletDecompose(const Mat &_src, const Mat &_lowFilter, const Mat &_highFilter);
Mat waveletReconstruct(const Mat &_src, const Mat &_lowFilter, const Mat &_highFilter);

int main()
{

	Mat Img;
	//Img = imread("D:\\�����ĵ�\\1_ѧУ\\�γ�\\ͼ����\\lena.png");
	Img = imread("E:\\JZS\\MyComputer\\1_ѧУ\\�γ�\\ͼ����\\lena.png");

	int height = Img.rows;
	int width = Img.cols;

	//��ʾԭʼͼ��
	namedWindow("ԭʼͼ��", 1);
	imshow("ԭʼͼ��", Img);
	Mat img_wdt;
	Mat I_gray;
	//��ʾ�Ҷ�ͼ��
	cvtColor(Img, I_gray, CV_RGB2GRAY);
	imshow("�Ҷ�ͼ��", I_gray);


	img_wdt = WDT(I_gray, "sym2", 1);
	namedWindow("wddt", 1);
	imshow("wddt", img_wdt);
	waitKey(0);


	return 0;

}

// С���任
Mat WDT(const Mat &_src, const string _wname, const int _level)
{
	//int reValue = THID_ERR_NONE;
	Mat src = Mat_<float>(_src);

	Mat dst = Mat::zeros(src.rows, src.cols, src.type());
	int N = src.rows;
	int D = src.cols;


	/// ��ͨ��ͨ�˲���
	Mat lowFilter;
	Mat highFilter;
	wavelet(_wname, lowFilter, highFilter);


	/// С���任
	int t = 1;
	int row = N;
	int col = D;


	while (t <= _level)
	{
		///�Ƚ�����С���任
		for (int i = 0; i < row; i++)
		{
			/// ȡ��src��Ҫ��������ݵ�һ��
			Mat oneRow = Mat::zeros(1, col, src.type());
			for (int j = 0; j < col; j++)
			{
				oneRow.at<float>(0, j) = src.at<float>(i, j);
			}
			oneRow = waveletDecompose(oneRow, lowFilter, highFilter);
			/// ��src��һ����ΪoneRow�е�����
			for (int j = 0; j < col; j++)
			{
				dst.at<float>(i, j) = oneRow.at<float>(0, j);
			}
		}
		/// С���б任
		for (int j = 0; j < col; j++)
		{
			/// ȡ��src���ݵ�һ������
			Mat oneCol = Mat::zeros(row, 1, src.type());
			for (int i = 0; i < row; i++)
			{
				oneCol.at<float>(i, 0) = dst.at<float>(i, j);
			}
			oneCol = (waveletDecompose(oneCol.t(), lowFilter, highFilter)).t();


			for (int i = 0; i < row; i++)
			{
				dst.at<float>(i, j) = oneCol.at<float>(i, 0);
			}
		}


		/// ����
		row /= 2;
		col /= 2;
		t++;
		src = dst;
	}
	return dst;
}

// С����任
Mat IWDT(const Mat &_src, const string _wname, const int _level)
{
	//int reValue = THID_ERR_NONE;
	Mat src = Mat_<float>(_src);
	Mat dst = Mat::zeros(src.rows, src.cols, src.type());
	int N = src.rows;
	int D = src.cols;


	/// ��ͨ��ͨ�˲���
	Mat lowFilter;
	Mat highFilter;
	wavelet(_wname, lowFilter, highFilter);


	/// С���任
	int t = 1;
	int row = N / std::pow(2., _level - 1);
	int col = D / std::pow(2., _level - 1);


	while (row <= N && col <= D)
	{
		/// С������任
		for (int j = 0; j < col; j++)
		{
			/// ȡ��src���ݵ�һ������
			Mat oneCol = Mat::zeros(row, 1, src.type());
			for (int i = 0; i < row; i++)
			{
				oneCol.at<float>(i, 0) = src.at<float>(i, j);
			}
			oneCol = waveletReconstruct(oneCol.t(), lowFilter, highFilter);


			for (int i = 0; i < row; i++)
			{
				dst.at<float>(i, j) = oneCol.at<float>(i, 0);
			}
		}


		///��С����任
		for (int i = 0; i < row; i++)
		{
			/// ȡ��src��Ҫ��������ݵ�һ��
			Mat oneRow = Mat::zeros(1, col, src.type());
			for (int j = 0; j < col; j++)
			{
				oneRow.at<float>(0, j) = dst.at<float>(i, j);
			}
			oneRow = waveletReconstruct(oneRow, lowFilter, highFilter);
			/// ��src��һ����ΪoneRow�е�����
			for (int j = 0; j < col; j++)
			{
				dst.at<float>(i, j) = oneRow.at<float>(0, j);
			}
		}




		row *= 2;
		col *= 2;
		src = dst;
	}


	return dst;
}

// ���ɲ�ͬ���͵�С��������ֻ��haar��sym2
void wavelet(const string _wname, Mat &_lowFilter, Mat &_highFilter)
{
	if (_wname == "sym2")
	{
		int N = 4;
		float h[] = { 0.483, 0.836, -0.224, -0.129 };
		float l[] = { -0.129, -0.224, 0.837, -0.483 };

		_lowFilter = Mat::zeros(1, N, CV_32F);
		_highFilter = Mat::zeros(1, N, CV_32F);

		for (int i = 0; i < N; i++)
		{
			_lowFilter.at<float>(0, i) = l[i];
			_highFilter.at<float>(0, i) = h[i];
		}

	}
}

// С���ֽ�
Mat waveletDecompose(const Mat &_src, const Mat &_lowFilter, const Mat &_highFilter)
{
	//�����������������ֹ����ִ��
	//ͼ����������˲�������������1
	//ͼ����������ڵ����˲���������
	assert(_src.rows == 1 && _lowFilter.rows == 1 && _highFilter.rows == 1);
	assert(_src.cols >= _lowFilter.cols && _src.cols >= _highFilter.cols);

	Mat &src = Mat_<float>(_src);

	int D = src.cols;

	Mat &lowFilter = Mat_<float>(_lowFilter);
	Mat &highFilter = Mat_<float>(_highFilter);

	/// Ƶ���˲�����ʱ������ifft( fft(x) * fft(filter)) = cov(x,filter) 
	Mat dst1 = Mat::zeros(1, D, src.type());
	Mat dst2 = Mat::zeros(1, D, src.type());

	filter2D(src, dst1, -1, lowFilter);
	filter2D(src, dst2, -1, highFilter);

	/// �²���
	//����ȫ0����
	Mat downDst1 = Mat::zeros(1, D / 2, src.type());
	Mat downDst2 = Mat::zeros(1, D / 2, src.type());

	resize(dst1, downDst1, downDst1.size());
	resize(dst2, downDst2, downDst2.size());

	/// ����ƴ��
	for (int i = 0; i < D / 2; i++)
	{
		src.at<float>(0, i) = downDst1.at<float>(0, i);
		src.at<float>(0, i + D / 2) = downDst2.at<float>(0, i);
	}

	return src;
}

// С���ؽ�
Mat waveletReconstruct(const Mat &_src, const Mat &_lowFilter, const Mat &_highFilter)
{
	assert(_src.rows == 1 && _lowFilter.rows == 1 && _highFilter.rows == 1);
	assert(_src.cols >= _lowFilter.cols && _src.cols >= _highFilter.cols);
	Mat &src = Mat_<float>(_src);


	int D = src.cols;


	Mat &lowFilter = Mat_<float>(_lowFilter);
	Mat &highFilter = Mat_<float>(_highFilter);


	/// ��ֵ;
	Mat Up1 = Mat::zeros(1, D, src.type());
	Mat Up2 = Mat::zeros(1, D, src.type());


	/// ��ֵΪ0
	//for ( int i=0, cnt=1; i<D/2; i++,cnt+=2 )
	//{
	//    Up1.at<float>( 0, cnt ) = src.at<float>( 0, i );     ///< ǰһ��
	//    Up2.at<float>( 0, cnt ) = src.at<float>( 0, i+D/2 ); ///< ��һ��
	//}


	/// ���Բ�ֵ
	Mat roi1(src, Rect(0, 0, D / 2, 1));
	Mat roi2(src, Rect(D / 2, 0, D / 2, 1));
	resize(roi1, Up1, Up1.size(), 0, 0, INTER_CUBIC);
	resize(roi2, Up2, Up2.size(), 0, 0, INTER_CUBIC);


	/// ǰһ���ͨ����һ���ͨ
	Mat dst1 = Mat::zeros(1, D, src.type());
	Mat dst2 = Mat::zeros(1, D, src.type());
	filter2D(Up1, dst1, -1, lowFilter);
	filter2D(Up2, dst2, -1, highFilter);


	/// ������
	dst1 = dst1 + dst2;


	return dst1;


}