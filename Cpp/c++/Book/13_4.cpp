//#include <iostream>
//#include <fstream>
//using namespace std;
//
//int main()
//{
//	int a[20];
//	ofstream outfile;
//	outfile.open("f1.dat", ios::out);
//	if(!outfile)
//	{
//		cerr << "open error!" << endl;
//		exit(1);
//	}
//	for(int i=0;i<10;i++)
//	{
//		cin >> a[i];
//		outfile << a[i] << ' ';
//	}
//	outfile.close();
//
//	outfile.open("f2.dat", ios::out);
//	if(!outfile)
//	{
//		cerr << "open error!" << endl;
//		exit(1);
//	}
//	for(int i=0;i<10;i++)
//	{
//		cin >> a[i];
//		outfile << a[i] << ' ';
//	}
//	outfile.close();
//
//	ifstream infile;
//	infile.open("f1.dat", ios::in);
//	if(!infile)
//	{
//		cerr << "open error!" << endl;
//		exit(1);
//	}
//	for(int i=0;i<10;i++)
//		infile >> a[i];
//	infile.close();
//
//	outfile.open("f2.dat", ios::app);
//	if(!outfile)
//	{
//		cerr << "open error!" << endl;
//		exit(1);
//	}
//	for(int i=0;i<10;i++)
//		outfile << a[i] << ' ';
//	outfile.close();
//
//	infile.open("f2.dat", ios::in);
//	if(!infile)
//	{
//		cerr << "open error!" << endl;
//		exit(1);
//	}
//	for(int i=0;i<20;i++)
//		infile >> a[i];
//	infile.close();
//
//	int m, n, k, tmp;
//	k=0;
//	for(m=0;m<19;m++)
//	{
//		for(n=m+1;n<20;n++)
//			if(a[k]<a[n])
//				k=n;
//		tmp=a[k];
//		a[k]=a[m];
//		a[m]=tmp;
//	}
//	
//	outfile.open("f2.dat", ios::out);
//	if(!outfile)
//	{
//		cerr << "open error!" << endl;
//		exit(1);
//	}
//	for(m=0;m<20;m++)
//		outfile << a[m] << ' ';
//	outfile.close();
//
//	system("pause");
//	return 0;
//}