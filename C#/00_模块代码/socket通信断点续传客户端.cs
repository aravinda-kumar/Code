//C# socket通信断点续传客户端
private void btn_SendBigFile_Click(object sender, EventArgs e)
{
	//获取文件路径
	string filePath = txtBox_Path.Text.Trim();
	//使用try-catch结构避免网络通信中出现异常，影响系统稳定性
	try
	{
		//读取选择的文件
		using (FileStream fsRead = new FileStream(filePath, FileMode.Open, FileAccess.Read))
		{
			//第一步：发送一个包，表示文件的长度
			long length = fsRead.Length;
			//Console.WriteLine("文件长度length ={0}", length);

			//将数据长度转换成字符串便于编码传输
			byte[] byteLength = Encoding.UTF8.GetBytes(length.ToString());
			//Console.WriteLine("byteLength={0}", byteLength.Length);
			
			//发送第一个数据包
			socketSend.Send(byteLength);

			//进行不到1S的延时，避免数据出现粘包的情况
			//using System.Diagnostics;
			//Stopwatch sw = new Stopwatch();
			//sw.Start();
			for (int i = 0; i < 300000000; i++);
			//sw.Stop();
			//Console.WriteLine(sw.Elapsed.ToString());
			
			//第二步：每次发送一个2k的包，如果文件较大，则会拆分为多个包
			byte[] buffer = new byte[1024 * 2];、
			
			//发送的字节数 
			long send = 0;   

			//大文件断点多次传输			
			while (true)  
			{
				//实际获得的数据长度
				int r = fsRead.Read(buffer, 0, buffer.Length);
				//Console.WriteLine("read r ={0}", r);
				//不再包含数据内容则退出
				if (r == 0)
				{
					break;
				}
				socketSend.Send(buffer, 0, r, SocketFlags.None);
				
				//更新已经发送的数据长度
				send += r;
				//Console.WriteLine("{0}: 已发送：{1}/{2}", socketSend.RemoteEndPoint, send, length);
			}
		}
	}
	catch{}
}