//C# socket通信断点续传服务器端
private void Receive()
{
	//使用try-catch结构避免网络通信中出现异常，影响系统稳定性
	try
	{
		//外层大循环，使得服务器能够不停的接收客户端传来的信息
		while (true)
		{
			//为了使多次获得的文件具有不同的名字，指定根据文件数目决定的命名规则
			string[] files = Directory.GetFiles(dirPath, "*.*");
			string fileName = (files.Length + 1).ToString() + ".jpg";
			string strPath = dirPath + "\\" + fileName;
			//Console.WriteLine("stepath={0}", strPath);
			
			//待接收文件的剩余字节长度
			long length = 0;
			//接收的大文件总的字节数
			long recive = 0; 
			while (true)
			{
				//Console.WriteLine("length ={0}", length);
				
				//开辟缓冲区，windows的socket通信的缓冲区大小为8KB
				//设立2KB的数据缓冲区
				byte[] buffer = new byte[1024 * 2];
				//将缓冲区复位，以免多余数据对结果产生影响
				Array.Clear(buffer, 0, buffer.Length);
				
				//实际接收数据包的长度
				//receive会阻塞线程，程序一直停在这
				int r = socketReceive.Receive(buffer, buffer.Length, SocketFlags.None);
				//Console.WriteLine("r ={0}", r);
				
				//如果没有接收到任何数据，退出整个循环
				if (r == 0)
				{
					break;
				}
				//判断大文件是否已经保存完
				if (length > 0)  
				{
					//写入给定文件
					using (FileStream fsWrite = new FileStream(strPath, FileMode.Append, FileAccess.Write))
					{
						fsWrite.Write(buffer, 0, r);
						//减去每次保存的字节数
						length -= r; 
						//Console.WriteLine("{0}: 已接收：{1}/{2}", socketReceive.RemoteEndPoint, recive - length, recive);
						
						//此时说明数据传输完毕
						if (length <= 0)
						{
							//Console.WriteLine(socketReceive.RemoteEndPoint + ": 接收文件成功");
							//将传输号的文件添加到列表框中
							//list_Pics.Items.Add(Path.GetFileNameWithoutExtension(strPath));
							//listFileFullName.Add(strPath);
							//将缓冲区复位，以免多余数据对结果产生影响
							Array.Clear(buffer, 0, buffer.Length);
							break;
						}
						
						//跳过本次循环，避免执行以下语句
						continue;
					}
				}
				//得到实际的数据内容
				string str_Length = Encoding.UTF8.GetString(buffer, 0, r);
				//Console.WriteLine("str_Length={0}", str_Length);
				
				//得到数据长度
				length = int.Parse(str_Length);
				recive = length;
			}
		}      
	}
	catch { }
}