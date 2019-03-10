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
		//string.h�еĺ���������ַ�������
		//strcat(m_str, p);
		m_str[i] = ch;
	}
	m_str[length] = '\0';
}

CMyString::CMyString(const char* str)
{
	//��ȡstrָ����ַ����ĳ���
	int nCount = 0;
	char *strtmp = const_cast<char*>(str);
	while (*strtmp != '\0')
	{
		nCount++;
		strtmp++;
	}
	//����β'\0'��һ���ռ�
	m_str = new char[nCount + 1];
	//�Կռ���и�ֵ
	for (int i = 0; i < nCount; i++)
	{
		m_str[i] = str[i];
	}
	m_str[nCount] = '\0';
}

CMyString::CMyString(const char* str, size_t length)
{
	//Ϊ�ַ�������ռ�
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

//������ص�ʵ��
ostream& operator << (ostream &cout, CMyString &str)
{
	cout << str.m_str;
	return cout;
}

//�������ص�ʵ��
istream& operator >> (istream &cin, CMyString &str)
{
	//�������뻺����
	char arr[20] = { 0 };
	cin >> arr;

	//�����ַ����ĳ���
	size_t nCount = 0;
	for (int i = 0; arr[i] != '\0'; i++)
	{
		nCount++;
	}

	//�ͷ�ԭ�пռ�
	delete str.m_str;
	//���·���ռ�
	str.m_str = new char[nCount + 1];

	//��ֵ
	for (size_t i = 0; i < nCount; i++)
	{
		str.m_str[i] = arr[i];
	}
	//��ӽ�β��ʶ��
	str.m_str[nCount] = '\0';

	return cin;
}