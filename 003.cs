using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence: ");
            string line = Console.ReadLine();

            line = line.Trim();

            if(line.EndsWith("hello"))
            {
                line = line.Substring(0, line.Length - 5);
                Console.WriteLine("This is the sentence: " + line);
            }
            else
            {
                string last = line.Substring(line.Length + 1);
                line = line.Replace(last, "hello");
                Console.WriteLine("Update sentence: " + line);
            }
    }
}
