//#include <iostream>
//#include <string>
//using namespace std;
//
//class Student
//{
//public:
//	void get_value();
//	void display();
//private:
//	int num;
//	string name;
//	char sex;
//};
//
//class Student1:private Student
//{
//public:
//	void get_value_1();
//	void display_1();
//private:
//	int age;
//	string addr;
//};
//
//int main()
//{
//	Student1 stu;
//	// private�̳�ʱ
//	// �����й��г�Ա�ͱ�����Ա����������˽�г�Ա
//	// �����е�˽�г�Ա�������в��ɼ�
//	// ���Զ�������Ķ�����ԣ��䲻���Ե��������˽�г�Ա
//	// ����Щ˽�г�Ա����ͨ�������еĳ�Ա���������е���
//	stu.get_value_1();
//	stu.display_1();
//
//	system("pause");
//	return 0;
//}
//
//void Student::get_value()
//{
//	cin >> num >> name >> sex;
//}
//
//void Student::display()
//{
//	cout << "num:" << num << endl;
//	cout << "name:" << name << endl;
//	cout << "sex:" << sex << endl;
//}
//
//void Student1::get_value_1()
//{	
//	get_value();
//	cin >> age >> addr;
//}
//
//void Student1::display_1()
//{	
//	display();
//	cout << "age:" << age << endl;
//	cout << "addr:" << addr << endl;
//}