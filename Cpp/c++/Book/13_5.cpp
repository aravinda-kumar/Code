//#include <iostream>
//#include <string>
//#include <fstream>
//#include <strstream>
//using namespace std;
//
//struct Worker
//{
//	int num;
//	string name;
//	int age;
//	double salary;
//};
//
//int main()
//{
//	Worker work[5]={1005, "zhu", 21, 80, 1004, "shuai", 22, 90, 1002, "johnson", 23, 100,1004, "jethro", 24, 110, 1001, "max", 24, 110};
//	int i,j,k;
//	Worker w_tmp;
//	k=0;
//	for(i=0;i<4;i++)
//	{
//		for(j=i+1;j<5;j++)
//			if(work[k].num > work[j].num)
//				k=j;
//		w_tmp=work[k];
//		work[k]=work[i];
//		work[i]=w_tmp;
//	}
//	for(i=0;i<5;i++)
//	{
//		cout << "No." << i+1 << endl;
//		cout << "Num:" << work[i].num << endl;
//		cout << "Name:" << work[i].name << endl;
//		cout << "Age:" << work[i].age << endl;
//		cout << "Salary:" << work[i].salary << endl << endl;
//	}
//	
//	cout << "****************************************************" << endl;
//
//	ofstream outfile;
//	outfile.open("work.txt", ios::out);
//	if(outfile == 0)
//	{
//		cerr << "open error!" << endl;
//		exit(1);
//	}
//	for(i=0;i<5;i++)
//		outfile << work[i].num << ' ' << work[i].name << ' ' << work[i].age << ' ' << work[i].salary << endl;
//	outfile.close();
//		
//	outfile.open("work.txt", ios::app);
//	if(outfile == 0)
//	{
//		cerr << "open error!" << endl;
//		exit(1);
//	}
//	Worker w_tmpa[2]={1006,"tom",12, 190, 1007, "jerry", 14, 134};
//	for(i=0;i<2;i++)
//		outfile << w_tmpa[i].num << ' ' << w_tmpa[i].name << ' ' << w_tmpa[i].age << ' ' << w_tmpa[i].salary << endl;
//	outfile.close();
//	
//	ifstream infile;
//	infile.open("work.txt",ios::in);
//	Worker works[7];
//	for(i=0;i<7;i++)
//		infile >> works[i].num >> works[i].name >> works[i].age >> works[i].salary;
//	infile.close();
//
//	for(i=0;i<7;i++)
//	{
//		cout << "No." << i+1 << endl;
//		cout << "Num:" << works[i].num << endl;
//		cout << "Name:" << works[i].name << endl;
//		cout << "Age:" << works[i].age << endl;
//		cout << "Salary:" << works[i].salary << endl << endl;
//	}
//	
//
//	int num_tmp;
//	cout << "输入查找的工号：";
//	cin >> num_tmp;
//	for(i=0;i<7;i++)
//	{
//		if(works[i].num == num_tmp)
//			break;
//	}
//	if(i==7)
//		cout << "查无此人" << endl;
//	else
//	{
//		cout << "No." << i+1 << endl;
//		cout << "Num:" << works[i].num << endl;
//		cout << "Name:" << works[i].name << endl;
//		cout << "Age:" << works[i].age << endl;
//		cout << "Salary:" << works[i].salary << endl << endl;
//	}
//
//	// cout << sizeof(works[i]) << endl;
//	char c[60];
//	ostrstream outstr(c, 60);
//	outstr << works[i].num << ' ' << works[i].name << ' ' << works[i].age << ' ' << works[i].salary;
//	outstr << ends;
//	cout << c << endl;
//
//	system("pause");
//	return 0;
//}