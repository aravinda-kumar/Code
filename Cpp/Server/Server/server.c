#define _WINSOCK_DEPRECATED_NO_WARNINGS

//头文件内容不区分大小写
#include<stdio.h>
#include<WinSock2.h>

#pragma comment(lib, "ws2_32.lib")

int main(void)
{
	//打开网络库
	//typedef unsigned short      WORD;
	WORD wdVersion = MAKEWORD(2, 2);	//低字节放主版本号，高字节放副版本号
	WSADATA wdMsgStr;
	//程序执行成功，会返回0
	//这些错误码实际上是宏定义
	int nRes = WSAStartup(wdVersion, &wdMsgStr);

	//错误码处理
	if (nRes != 0)
	{
		switch (nRes)
		{
			case WSASYSNOTREADY: 
				printf("系统环境错误\n");
				break;
			case WSAVERNOTSUPPORTED: 
				printf("更新网络库\n");
				break;
			case WSAEINPROGRESS: 
				printf("请重新启动程序\n");
				break;
			case WSAEFAULT: 
				printf("端口被占用\n");
				break;
		}
	}

	//网络库版本校验
	//HIBYTE LOBYTE 取字的高字节和低字节
	if (2 != HIBYTE(wdMsgStr.wVersion) || 2 != LOBYTE(wdMsgStr.wVersion))
	{
		//打开的版本不对
		//清理网络库或者关闭网络库
		WSACleanup();
		return -1;
	}

	//创建一个socket,SOCKET本质就是一个整数
	//第一个参数ip(ipv4) 第二个 流式socket， 第三个  TCP协议
	SOCKET socketServer = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);

	//套接字使用完毕需要销毁 -- closesocket(SOCKET s)
	//失败返回INVALID_SOCKET
	if (INVALID_SOCKET == socketServer)
	{
		//获取失败的错误码, 需要出错之后调用，而且要离相应函数较近
		int a = WSAGetLastError();

		//套接字创建失败，直接关闭网络库
		WSACleanup();
		return -1;
	}

	//连接函数
	//int bind(SOCKET s, const sockaddr *addr, int namelen)
	//参数一 套接字
	//参数二 sockaddr的指针
	//参数三 sockaddr的长度

	struct sockaddr_in si;
	si.sin_family = AF_INET;
	//用htons转换成unsigned int
	si.sin_port = htons(50000);
	si.sin_addr.S_un.S_addr = inet_addr("127.0.0.1"); 

	if (bind(socketServer, (const struct sockaddr*)&si, sizeof(si)) == SOCKET_ERROR)
	{
		//执行出错
		//获取错误码
		int a = WSAGetLastError();

		//关闭套接字
		closesocket(socketServer);
		//关闭网络库
		WSACleanup();

		return -1;
	}

	//开始监听
	if (SOCKET_ERROR == listen(socketServer, SOMAXCONN))
	{
		//监听失败
		//获取错误码
		int a = WSAGetLastError();

		//关闭套接字和网络库
		closesocket(socketServer);
		WSACleanup();
		return -1;
	}

	//接收通信请求
	//创建客户端的套接字
	struct sockaddr_in clientMsg;
	int len = sizeof(clientMsg);
	//如果用不到客户端的套接字，第二第三个参数可以设为NULL
	SOCKET socketclient = accept(socketServer, (struct sockaddr*)&clientMsg, &len);
	if (INVALID_SOCKET == socketclient)
	{
		//获取失败的错误码, 需要出错之后调用，而且要离相应函数较近
		int a = WSAGetLastError();

		printf("客户端连接成功\n");

		closesocket(socketServer);
		closesocket(socketclient);
		//套接字创建失败，直接关闭网络库
		WSACleanup();
		return -1;
	}
	//在此一直等到客户端连接，程序阻塞(同步)

	printf("客户端连接成功\n");

	char buf[1500] = { 0 };
	//recv也会阻塞进程，会等客户端传送数据
	//参数4 -- 详解
	//默认写0 读取之后会删除缓冲区的空间
	int res = recv(socketclient, buf, 1499, 0);
	if (0 == res)
	{
		printf("客户端连接中断...");
	}
	else if (SOCKET_ERROR == res)
	{
		//信息传送出错
		int error_code = WSAGetLastError();
		switch (error_code)
		{
		default:
			break;
		}
	}
	printf("%d   %s\n", res, buf);

	//先关闭socket在关闭网络库，SOCKTE隶属于网络库
	closesocket(socketServer);
	closesocket(socketclient);
	WSACleanup();
	system("pause");
	return 0;
}