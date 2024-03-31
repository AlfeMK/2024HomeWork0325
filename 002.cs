using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter word A:");
            string a=Console.ReadLine();

            while (string.IsNullOrWhiteSpace(a))
            {
                Console.WriteLine("null input detect, please enter word A again");
                a = Console.ReadLine();
            }

            Console.WriteLine("Please enter word B:");
            string b = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(b))
            {
                Console.WriteLine("null input detect, please enter word B again");
                b = Console.ReadLine();
            }

            if (a.Length > b.Length)
            {
                a = a + b;
                
            }
            else
            {
                int midstr = a.Length / 2;
                a = a.Insert(midstr, b);
            }

            Console.WriteLine("Result: " + a);

            Console.ReadLine();
        }
    }
}
