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
	//返回const指针和常函数const位置是不同的，放在后面是常函数，前面是返回常指针
	//常函数不允许对m_str进行任何操作
	const char* c_str() const;

	~CMyString();

	friend ostream& operator << (ostream &cout, CMyString &str);
	friend istream& operator >> (istream &cin, CMyString &str);
};

//输出重载
ostream& operator << (ostream &cout, CMyString &str);
//输入重载
istream& operator >> (istream &cin, CMyString &str);
#endif // !_MYSTRING_H_