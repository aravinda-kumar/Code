//#include <iostream>
//using namespace std;
//
//int main()
//{
//	int a = 21;
//	cout.setf(ios::showbase);
//	cout << "dec:" << a << endl;
//	//cout.unsetf(ios::dec);
//
//	cout.setf(ios::hex);
//	cout << "hex:" << a << endl;
//	cout.unsetf(ios::hex);
//	
//	cout.setf(ios::oct);
//	cout << "oct:" << a << endl;
//	cout.unsetf(ios::oct);
//
//	cout << "*********************************" << endl;
//		
//	char *pt = "china";
//	cout.width(10);
//	cout << pt << endl;
//
//	cout.width(10);
//	cout.fill('*');
//	cout << pt << endl;
//
//	cout << "*********************************" << endl;
//
//	double pi = 22.0/7.0;
//	cout.setf(ios::scientific);
//	cout << "pi=";
//	cout.width(14);
//	cout << pi << endl;
//	cout.unsetf(ios::scientific);
//
//	cout.setf(ios::fixed);
//	cout.width(12);
//	cout.setf(ios::showpos);
//	cout.setf(ios::internal);
//	cout.precision(6);
//	cout << pi << endl;
//	
//	cout.put(71).put(79).put(79).put(68).put('\n');
//
//	//char c;
//	//cout << "enter a sentence:" << endl;
//	//while((c=cin.get())!=EOF)
//	//	cout.put(c);
//	//cout.put('\n');
//		
//	//char ch[10];
//	//char *pt1=ch;
//	//cin.get(pt1, 10, '\n');
//	//cout << pt1;
//
//	char c;
//	while(!cin.eof())
//		if((c=cin.get()) != ' ')
//			cout.put(c);
//
//	system("pause");
//	return 0;
//}