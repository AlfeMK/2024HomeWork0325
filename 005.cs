using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first word:");
            string str1=Console.ReadLine();
            Console.WriteLine("Please enter the second word:");
            string str2 = Console.ReadLine();

            if (string.Compare(str1, str2) == 0)
            {
                Console.WriteLine("The two words is the same.");
            }
            else
            {
                if (string.Compare(str1.Substring(0, 3), str2.Substring(0, 3))==0)
                {
                    Console.WriteLine("The first three letter of both words are the same.");
                }
                else
                {
                    Console.WriteLine("The two words are differevnce and the first three letter of both words are not the same.");
                }
            }
        }
    }
}
