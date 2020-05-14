using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConsoleApp1.SqlConn;

namespace ConsoleApp1 
{
    class Program
    {
        static void Main(string[] args)
        {
            // вставить данные
            InsertData.Insert();

            // other part
            LRUCache h = new LRUCache(10);          
            Console.WriteLine("sdsd");
            Console.ReadKey();
        }
    }
}
