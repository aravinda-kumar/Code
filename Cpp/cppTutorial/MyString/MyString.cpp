#include "MyString.h"

CMyString::CMyString()
{
	m_str = new char('\0');
}

CMyString::CMyString(size_t length, char ch)
{
	m_str = new char[length + 1];
	char *p = &ch;
	for (size_t i = 0; i < length; i++)
	{
		//string.h中的函数仅针对字符串数组
		//strcat(m_str, p);
		m_str[i] = ch;
	}
	m_str[length] = '\0';
}

CMyString::CMyString(const char* str)
{
	//获取str指向的字符串的长度
	int nCount = 0;
	char *strtmp = const_cast<char*>(str);
	while (*strtmp != '\0')
	{
		nCount++;
		strtmp++;
	}
	//给结尾'\0'加一个空间
	m_str = new char[nCount + 1];
	//对空间进行赋值
	for (int i = 0; i < nCount; i++)
	{
		m_str[i] = str[i];
	}
	m_str[nCount] = '\0';
}

CMyString::CMyString(const char* str, size_t length)
{
	//为字符串申请空间
	m_str = new char[length + 1];
	for (size_t i = 0; i < length; i++)
	{
		m_str[i] = str[i];
	}
	m_str[length] = '\0';
}

CMyString::CMyString(const CMyString& str)
{
	const char *p = str.c_str();
	char *ptmp = const_cast<char*>(p);
	size_t nCount = 0;
	while (*ptmp != '\0')
	{
		nCount++;
		ptmp++;
	}
	m_str = new char[nCount + 1];
	for (size_t i = 0; i < nCount; i++)
	{
		m_str[i] = p[i];
	}
	m_str[nCount] = '\0';
}

const char* CMyString::c_str() const
{
	return m_str;
}

CMyString::~CMyString()
{
	if (NULL == m_str)
		delete[] m_str;
}

//输出重载的实现
ostream& operator << (ostream &cout, CMyString &str)
{
	cout << str.m_str;
	return cout;
}

//输入重载的实现
istream& operator >> (istream &cin, CMyString &str)
{
	//创建输入缓冲区
	char arr[20] = { 0 };
	cin >> arr;

	//计算字符串的长度
	size_t nCount = 0;
	for (int i = 0; arr[i] != '\0'; i++)
	{
		nCount++;
	}

	//释放原有空间
	delete str.m_str;
	//重新分配空间
	str.m_str = new char[nCount + 1];

	//赋值
	for (size_t i = 0; i < nCount; i++)
	{
		str.m_str[i] = arr[i];
	}
	//添加结尾标识符
	str.m_str[nCount] = '\0';

	return cin;
}