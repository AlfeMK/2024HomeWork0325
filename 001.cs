namespace HW001
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a word:");
            string iput = Console.ReadLine();
            switch (iput.ToLower()[0])
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Output your word:" + iput.ToUpper());
                    break;

                default:
                    Console.WriteLine("Output your word:" + iput.ToLower()); break;
            }
            Console.ReadLine();
        }
}
