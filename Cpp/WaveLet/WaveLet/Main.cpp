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
	//Img = imread("D:\\个人文档\\1_学校\\课程\\图像处理\\lena.png");
	Img = imread("E:\\JZS\\MyComputer\\1_学校\\课程\\图像处理\\lena.png");

	int height = Img.rows;
	int width = Img.cols;

	//显示原始图像
	namedWindow("原始图像", 1);
	imshow("原始图像", Img);
	Mat img_wdt;
	Mat I_gray;
	//显示灰度图像
	cvtColor(Img, I_gray, CV_RGB2GRAY);
	imshow("灰度图像", I_gray);


	img_wdt = WDT(I_gray, "sym2", 1);
	namedWindow("wddt", 1);
	imshow("wddt", img_wdt);
	waitKey(0);


	return 0;

}

// 小波变换
Mat WDT(const Mat &_src, const string _wname, const int _level)
{
	//int reValue = THID_ERR_NONE;
	Mat src = Mat_<float>(_src);

	Mat dst = Mat::zeros(src.rows, src.cols, src.type());
	int N = src.rows;
	int D = src.cols;


	/// 高通低通滤波器
	Mat lowFilter;
	Mat highFilter;
	wavelet(_wname, lowFilter, highFilter);


	/// 小波变换
	int t = 1;
	int row = N;
	int col = D;


	while (t <= _level)
	{
		///先进行行小波变换
		for (int i = 0; i < row; i++)
		{
			/// 取出src中要处理的数据的一行
			Mat oneRow = Mat::zeros(1, col, src.type());
			for (int j = 0; j < col; j++)
			{
				oneRow.at<float>(0, j) = src.at<float>(i, j);
			}
			oneRow = waveletDecompose(oneRow, lowFilter, highFilter);
			/// 将src这一行置为oneRow中的数据
			for (int j = 0; j < col; j++)
			{
				dst.at<float>(i, j) = oneRow.at<float>(0, j);
			}
		}
		/// 小波列变换
		for (int j = 0; j < col; j++)
		{
			/// 取出src数据的一行输入
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


		/// 更新
		row /= 2;
		col /= 2;
		t++;
		src = dst;
	}
	return dst;
}

// 小波逆变换
Mat IWDT(const Mat &_src, const string _wname, const int _level)
{
	//int reValue = THID_ERR_NONE;
	Mat src = Mat_<float>(_src);
	Mat dst = Mat::zeros(src.rows, src.cols, src.type());
	int N = src.rows;
	int D = src.cols;


	/// 高通低通滤波器
	Mat lowFilter;
	Mat highFilter;
	wavelet(_wname, lowFilter, highFilter);


	/// 小波变换
	int t = 1;
	int row = N / std::pow(2., _level - 1);
	int col = D / std::pow(2., _level - 1);


	while (row <= N && col <= D)
	{
		/// 小波列逆变换
		for (int j = 0; j < col; j++)
		{
			/// 取出src数据的一行输入
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


		///行小波逆变换
		for (int i = 0; i < row; i++)
		{
			/// 取出src中要处理的数据的一行
			Mat oneRow = Mat::zeros(1, col, src.type());
			for (int j = 0; j < col; j++)
			{
				oneRow.at<float>(0, j) = dst.at<float>(i, j);
			}
			oneRow = waveletReconstruct(oneRow, lowFilter, highFilter);
			/// 将src这一行置为oneRow中的数据
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

// 生成不同类型的小波，现在只有haar，sym2
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

// 小波分解
Mat waveletDecompose(const Mat &_src, const Mat &_lowFilter, const Mat &_highFilter)
{
	//如果不符合条件，终止程序执行
	//图像的行数和滤波器的行数都是1
	//图像的列数大于等于滤波器的列数
	assert(_src.rows == 1 && _lowFilter.rows == 1 && _highFilter.rows == 1);
	assert(_src.cols >= _lowFilter.cols && _src.cols >= _highFilter.cols);

	Mat &src = Mat_<float>(_src);

	int D = src.cols;

	Mat &lowFilter = Mat_<float>(_lowFilter);
	Mat &highFilter = Mat_<float>(_highFilter);

	/// 频域滤波，或时域卷积；ifft( fft(x) * fft(filter)) = cov(x,filter) 
	Mat dst1 = Mat::zeros(1, D, src.type());
	Mat dst2 = Mat::zeros(1, D, src.type());

	filter2D(src, dst1, -1, lowFilter);
	filter2D(src, dst2, -1, highFilter);

	/// 下采样
	//创建全0矩阵
	Mat downDst1 = Mat::zeros(1, D / 2, src.type());
	Mat downDst2 = Mat::zeros(1, D / 2, src.type());

	resize(dst1, downDst1, downDst1.size());
	resize(dst2, downDst2, downDst2.size());

	/// 数据拼接
	for (int i = 0; i < D / 2; i++)
	{
		src.at<float>(0, i) = downDst1.at<float>(0, i);
		src.at<float>(0, i + D / 2) = downDst2.at<float>(0, i);
	}

	return src;
}

// 小波重建
Mat waveletReconstruct(const Mat &_src, const Mat &_lowFilter, const Mat &_highFilter)
{
	assert(_src.rows == 1 && _lowFilter.rows == 1 && _highFilter.rows == 1);
	assert(_src.cols >= _lowFilter.cols && _src.cols >= _highFilter.cols);
	Mat &src = Mat_<float>(_src);


	int D = src.cols;


	Mat &lowFilter = Mat_<float>(_lowFilter);
	Mat &highFilter = Mat_<float>(_highFilter);


	/// 插值;
	Mat Up1 = Mat::zeros(1, D, src.type());
	Mat Up2 = Mat::zeros(1, D, src.type());


	/// 插值为0
	//for ( int i=0, cnt=1; i<D/2; i++,cnt+=2 )
	//{
	//    Up1.at<float>( 0, cnt ) = src.at<float>( 0, i );     ///< 前一半
	//    Up2.at<float>( 0, cnt ) = src.at<float>( 0, i+D/2 ); ///< 后一半
	//}


	/// 线性插值
	Mat roi1(src, Rect(0, 0, D / 2, 1));
	Mat roi2(src, Rect(D / 2, 0, D / 2, 1));
	resize(roi1, Up1, Up1.size(), 0, 0, INTER_CUBIC);
	resize(roi2, Up2, Up2.size(), 0, 0, INTER_CUBIC);


	/// 前一半低通，后一半高通
	Mat dst1 = Mat::zeros(1, D, src.type());
	Mat dst2 = Mat::zeros(1, D, src.type());
	filter2D(Up1, dst1, -1, lowFilter);
	filter2D(Up2, dst2, -1, highFilter);


	/// 结果相加
	dst1 = dst1 + dst2;


	return dst1;


}