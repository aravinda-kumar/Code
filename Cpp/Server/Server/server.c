#define _WINSOCK_DEPRECATED_NO_WARNINGS

//ͷ�ļ����ݲ����ִ�Сд
#include<stdio.h>
#include<WinSock2.h>

#pragma comment(lib, "ws2_32.lib")

int main(void)
{
	//�������
	//typedef unsigned short      WORD;
	WORD wdVersion = MAKEWORD(2, 2);	//���ֽڷ����汾�ţ����ֽڷŸ��汾��
	WSADATA wdMsgStr;
	//����ִ�гɹ����᷵��0
	//��Щ������ʵ�����Ǻ궨��
	int nRes = WSAStartup(wdVersion, &wdMsgStr);

	//�����봦��
	if (nRes != 0)
	{
		switch (nRes)
		{
			case WSASYSNOTREADY: 
				printf("ϵͳ��������\n");
				break;
			case WSAVERNOTSUPPORTED: 
				printf("���������\n");
				break;
			case WSAEINPROGRESS: 
				printf("��������������\n");
				break;
			case WSAEFAULT: 
				printf("�˿ڱ�ռ��\n");
				break;
		}
	}

	//�����汾У��
	//HIBYTE LOBYTE ȡ�ֵĸ��ֽں͵��ֽ�
	if (2 != HIBYTE(wdMsgStr.wVersion) || 2 != LOBYTE(wdMsgStr.wVersion))
	{
		//�򿪵İ汾����
		//�����������߹ر������
		WSACleanup();
		return -1;
	}

	//����һ��socket,SOCKET���ʾ���һ������
	//��һ������ip(ipv4) �ڶ��� ��ʽsocket�� ������  TCPЭ��
	SOCKET socketServer = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);

	//�׽���ʹ�������Ҫ���� -- closesocket(SOCKET s)
	//ʧ�ܷ���INVALID_SOCKET
	if (INVALID_SOCKET == socketServer)
	{
		//��ȡʧ�ܵĴ�����, ��Ҫ����֮����ã�����Ҫ����Ӧ�����Ͻ�
		int a = WSAGetLastError();

		//�׽��ִ���ʧ�ܣ�ֱ�ӹر������
		WSACleanup();
		return -1;
	}

	//���Ӻ���
	//int bind(SOCKET s, const sockaddr *addr, int namelen)
	//����һ �׽���
	//������ sockaddr��ָ��
	//������ sockaddr�ĳ���

	struct sockaddr_in si;
	si.sin_family = AF_INET;
	//��htonsת����unsigned int
	si.sin_port = htons(50000);
	si.sin_addr.S_un.S_addr = inet_addr("127.0.0.1"); 

	if (bind(socketServer, (const struct sockaddr*)&si, sizeof(si)) == SOCKET_ERROR)
	{
		//ִ�г���
		//��ȡ������
		int a = WSAGetLastError();

		//�ر��׽���
		closesocket(socketServer);
		//�ر������
		WSACleanup();

		return -1;
	}

	//��ʼ����
	if (SOCKET_ERROR == listen(socketServer, SOMAXCONN))
	{
		//����ʧ��
		//��ȡ������
		int a = WSAGetLastError();

		//�ر��׽��ֺ������
		closesocket(socketServer);
		WSACleanup();
		return -1;
	}

	//����ͨ������
	//�����ͻ��˵��׽���
	struct sockaddr_in clientMsg;
	int len = sizeof(clientMsg);
	//����ò����ͻ��˵��׽��֣��ڶ�����������������ΪNULL
	SOCKET socketclient = accept(socketServer, (struct sockaddr*)&clientMsg, &len);
	if (INVALID_SOCKET == socketclient)
	{
		//��ȡʧ�ܵĴ�����, ��Ҫ����֮����ã�����Ҫ����Ӧ�����Ͻ�
		int a = WSAGetLastError();

		printf("�ͻ������ӳɹ�\n");

		closesocket(socketServer);
		closesocket(socketclient);
		//�׽��ִ���ʧ�ܣ�ֱ�ӹر������
		WSACleanup();
		return -1;
	}
	//�ڴ�һֱ�ȵ��ͻ������ӣ���������(ͬ��)

	printf("�ͻ������ӳɹ�\n");

	char buf[1500] = { 0 };
	//recvҲ���������̣���ȿͻ��˴�������
	//����4 -- ���
	//Ĭ��д0 ��ȡ֮���ɾ���������Ŀռ�
	int res = recv(socketclient, buf, 1499, 0);
	if (0 == res)
	{
		printf("�ͻ��������ж�...");
	}
	else if (SOCKET_ERROR == res)
	{
		//��Ϣ���ͳ���
		int error_code = WSAGetLastError();
		switch (error_code)
		{
		default:
			break;
		}
	}
	printf("%d   %s\n", res, buf);

	//�ȹر�socket�ڹر�����⣬SOCKTE�����������
	closesocket(socketServer);
	closesocket(socketclient);
	WSACleanup();
	system("pause");
	return 0;
}