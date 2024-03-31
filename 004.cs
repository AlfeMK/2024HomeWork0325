using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string: ");
            string str=Console.ReadLine();
            Console.WriteLine("Please enter a char: ");
            char cha = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int charIndex = str.IndexOf(cha);
            if (charIndex != -1)
            {
                Console.WriteLine($"The char '{cha}' exist in {charIndex}。");
            }
            else
            {
                Console.WriteLine($"The char '{cha}' doesn't exist in the string");
                Console.WriteLine("Please enter a word to insert: ");
                char ins = Console.ReadKey().KeyChar;
                Console.WriteLine();

                Console.WriteLine("Update sentence: ");
                string filledString = str.PadLeft(str.Length + 1, ins).PadRight(str.Length + 2, ins);
                Console.WriteLine(filledString);
            }
        }
    }
}
