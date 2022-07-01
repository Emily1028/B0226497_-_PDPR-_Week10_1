using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR _Week10_1");
            string ans = "yes";
            while (ans == "yes")
            {
                Console.Write("請輸入年齡:");
                string ageStr = Console.ReadLine();
                int age = int.Parse(ageStr);
                if (age >= 20)
                {
                    Console.WriteLine("年齡:{0}，需購買普通票", age);
                }
                else
                {
                    Console.WriteLine("年齡:{0}，可購買優待票", age);   
                }
                Console.Write("請輸入\"yes\"繼續計算，其它任意鍵離開:");
                ans = Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
