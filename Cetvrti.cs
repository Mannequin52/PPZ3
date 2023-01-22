using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPZ3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n3.4");
            Console.WriteLine("Upišite neki pozitivni broj:");
            string s34 = Console.ReadLine();
            int x34 = Convert.ToInt32(s34);
            for (int i = 1; i < x34; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine();
            }
        

    }
}
    }

