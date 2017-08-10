using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter; letter = 'a';
            int number; number = 100;
            float body = 98.6f;
            double pi = 3.14159;
            decimal sum = 1000.00m;
            bool flag = false;
            string text = "C# is fun";

            Console.WriteLine("Char letter:\t" + letter);
            Console.WriteLine("int number:\t" + number);
            Console.WriteLine("float body:\t" + body);
            Console.WriteLine("double pi:\t + pi");
            Console.WriteLine("decimal sum:\t" + sum);
            Console.WriteLine("bool flag:\t" + flag);
            Console.WriteLine("string text:\t" + text);
            Console.ReadKey();

        }
    }
}
