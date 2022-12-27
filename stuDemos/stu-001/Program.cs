using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stu_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = "http://127.0.0.1:5000";

            try
            {
                using (WebApp.Start<Startup>(url))
                {
                    Console.WriteLine($"开始监听: {url}, 按任意键结束 ...");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
        }   
    }
}
