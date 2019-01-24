while (true)
{
	DateTime dt = DateTime.Now;
	string fileName = dt.ToString("yyyy-MM-dd-HH-mm-ss") + ".jpg";
	string strPath = dirPath + "\\" + fileName;

	byte[] buffer = new byte[1024 * 1024];
	int r = socketReceive.Receive(buffer, buffer.Length, SocketFlags.None);
	if (r == 0) break;

	using (FileStream fsWrite = new FileStream(strPath, FileMode.OpenOrCreate, FileAccess.Write))
	{
		fsWrite.Write(buffer, 0, r);
	}

	list_Pics.Items.Add(Path.GetFileNameWithoutExtension(strPath));
	listFileFullName.Add(strPath);
}