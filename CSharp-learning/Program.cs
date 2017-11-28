using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,world.");
            String str = "sex=1,year=1985,month=4,day=1,hour=0,minute=0,sex2=0,year2=1985,month2=4,day2=1,hour2=0,minute2=0";
            String[] arr = str.Split(',');

            foreach(String t in arr)
            {
                Console.WriteLine(t);
                String[] keyvalue = t.Split('=');
                Console.WriteLine(keyvalue[1]);
            }

            Console.Read();
        }
    }
}
