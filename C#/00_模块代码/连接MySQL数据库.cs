//C# 程序连接到MySQL数据库
//mssql 过程基本类似

//添加命名空间
using MySql.Data.MySqlClient;

//申明两个变量一个用户名一个密码
string user_id = txtBox_User.Text.Trim();
string user_pwd = txtBox_Pwd.Text.Trim();

//判断输入的用户名和密码是否为空
//string.IsNullOrEmpty()方法也可以实现
if (user_id == string.Empty || user_pwd == string.Empty)
{
	MessageBox.Show("账户密码不能为空！");
}
else
{
	//连接数据库用的拼接字符串
	//获取方式
	//VS IDE 工具->连接到数据库->高级
	string connection = "Server=localhost;user=root;pwd=950810;database=zhushuai";
	
	//创建MySQL连接类，用来根据拼接字连接数据库
	MySqlConnection mysqlconnection = new MySqlConnection(connection);

	//判断连接状态
	if(mysqlconnection.State == ConnectionState.Closed)
	{
		mysqlconnection.Open();
	}
	
	//创建查询语句
	string search = "SELECT user_pwd FROM user_info WHERE user_id = '" + user_id + "'";
	
	//创建MySQL查询类，用来执行查询语句
	MySqlCommand mysqlcommand = new MySqlCommand(search, mysqlconnection);
	
	//获取MySQL查询的结果
	MySqlDataReader reader = mysqlcommand.ExecuteReader();
	if(reader.Read())
	{
		if(reader["user_pwd"].ToString() == user_pwd)
		{
			MessageBox.Show("登录成功");
		}
		else
		{
			MessageBox.Show("登录失败");
		}
	}
	else
	{
		MessageBox.Show("用户不存在");
	}
}