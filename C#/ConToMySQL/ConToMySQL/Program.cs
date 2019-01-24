using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConToMySQL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(conn1());
            Console.ReadKey();
        }

        //sqlclient
        private static string conn1()
        {
            string connection = "Server=localhost;user=root;pwd=950810;database=zhushuai";
            MySqlConnection mysqlconnection = new MySqlConnection(connection);
            if(mysqlconnection.State == System.Data.ConnectionState.Closed)
            {
                mysqlconnection.Open();
            }
            if (mysqlconnection.State == System.Data.ConnectionState.Open)
            {
                return "连接成功";
            }
            return "连接失败";
        }
    }
}
