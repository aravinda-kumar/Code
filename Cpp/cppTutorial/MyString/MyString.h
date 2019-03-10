#ifndef _MYSTRING_H_
#define _MYSTRING_H_

#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
using namespace std;

class CMyString
{
private:
	char *m_str;
public:
	CMyString();
	CMyString(size_t length, char ch);
	CMyString(const char* str);
	CMyString(const char* str, size_t length);

	CMyString(const CMyString& str);
public:
	//����constָ��ͳ�����constλ���ǲ�ͬ�ģ����ں����ǳ�������ǰ���Ƿ��س�ָ��
	//�������������m_str�����κβ���
	const char* c_str() const;

	~CMyString();

	friend ostream& operator << (ostream &cout, CMyString &str);
	friend istream& operator >> (istream &cin, CMyString &str);
};

//�������
ostream& operator << (ostream &cout, CMyString &str);
//��������
istream& operator >> (istream &cin, CMyString &str);
#endif // !_MYSTRING_H_