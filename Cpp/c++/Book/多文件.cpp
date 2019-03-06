//#include <iostream>
//#include <fstream>
//using namespace std;
//
//int main()
//{
//	char ch[20];
//	char *pt=ch;
//	char tmp;
//	int i;
//	ofstream outfile;
//	ifstream infile;
//	outfile.open("f2.txt", ios::out);
//	if(outfile == 0)
//	{
//		cerr << "Open error!" << endl;
//		exit(1);
//	}
//
//	for(i=0;i<20;i++)
//	{
//		cin >> *(pt+i);
//		outfile << *(pt+i);
//	}
//
//	outfile.close();
//
//	infile.open("f2.txt", ios::in);
//	if(infile == 0)
//	{
//		cerr << "Open error!" << endl;
//		exit(1);
//	}
//	
//	outfile.open("f3.txt", ios::out);
//	if(outfile == 0)
//	{
//		cerr << "Open error!" << endl;
//		exit(1);
//	}
//
//	while(infile.get(tmp))
//	{	
//		outfile.put(tmp);
//		cout << tmp;
//	}
//	cout << endl;
//
//	infile.close();
//	outfile.close();
//	
//	
//
//	system("pause");
//	return 0;
//}