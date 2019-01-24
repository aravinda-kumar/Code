using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace 学生登录
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }


        //登录
        private void btn_Login_Click(object sender, EventArgs e)
        {

            //申明两个变量一个用户名一个密码
            string user_id = txtBox_User.Text.Trim();
            string user_pwd = txtBox_Pwd.Text.Trim();

            if (user_id == string.Empty || user_pwd == string.Empty)
            {
                MessageBox.Show("账户密码不能为空！");
            }  
            else
            {
                string connection = "Server=localhost;user=root;pwd=950810;database=zhushuai";
                MySqlConnection mysqlconnection = new MySqlConnection(connection);

                
                if(mysqlconnection.State == ConnectionState.Closed)
                {
                    mysqlconnection.Open();
                }
                string search = "SELECT user_pwd FROM user_info WHERE user_id = '" + user_id + "'";
                MySqlCommand mysqlcommand = new MySqlCommand(search, mysqlconnection);
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
        }

        //取消按钮
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            MessageBox.Show("欢迎使用");
            
        }
    }
}
