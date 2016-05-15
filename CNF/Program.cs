using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CNF
{
    class Program
    {
        static void Main(string[] args)
        {
            string c = "C:\\Users\\junrui\\Desktop\\hello.LNS";
            string a = "this is my world!";
            string b;
            StreamReader sr = new StreamReader(c);
            sr.Close();
            //StreamWriter sw = File.CreateText(c);
            StreamWriter sw = File.AppendText(c);//插入
            sw.WriteLine(sr);
            sw.WriteLine();
            sw.WriteLine(a);
            sw.WriteLine("end");
            sw.WriteLine("you should out ！");
            sw.Close();
            StreamReader y = File.OpenText(c);
            string f;
            while((f=y.ReadLine())!=null)
               
                {
                Console.WriteLine(f);
            }
            
        }
    }

}
