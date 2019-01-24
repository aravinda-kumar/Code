using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.Script.Serialization;
using System.IO;

namespace Json
{
    class Person
    {
        //Person()
        //{

        //}
        //public Person(string name, int age)
        //{
        //    _Name = name;
        //    _Age = age;
        //}
        public string _Name { get; set; }
        public int _Age { get; set; }

        public override string ToString()
        {
            return _Name + ": " + _Age.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            //生成JSON文件
            //Person person = new Person("zhushuai", 24);
            
            //string outputJSON = ser.Serialize(person);
            //File.WriteAllText("output.json", outputJSON);
            //解析JSON文件
            string JSONstring = File.ReadAllText("output.json");
            Person readPerson = ser.Deserialize<Person>(JSONstring);
            Console.WriteLine(readPerson);

            Person person = new Person() { _Name = "johnson", _Age = 18 };
            Console.WriteLine(person);

            Console.ReadKey();
        }
    }
}
