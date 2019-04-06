using System;
using System.Threading;

namespace RNGname
{
    class Program
    {
        static void Main(string[] args)
        {
            mainCheck();
            mainDoM();
            
        }

        private static void mainDoM()
        {
            string z = mainDo();

            if(z == "q" || z == "Q")
            {
                Console.ReadKey();
                return;
            }
            else
            {
                mainDoM();
            }
        }

        static void mainCheck()
        {
            string text = "Welcome to the password generator. :) \n";
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }
        }

        static string mainDo()
        {
            string z;
            Console.WriteLine("Input the number of characters for your password...");

            NameGen rngN = new NameGen();
            int result = 0;

            string input = Console.ReadLine();
            try
            {
                result = Int32.Parse(input);
                Console.WriteLine(result);
            }
            catch (FormatException)
            {
                Console.WriteLine($"'{input}' not a number");
            }

            string x = rngN.cName(result);

            Console.WriteLine($"Password: {x}");
            Console.WriteLine("Press Q to quit, or press enter for another password");
            z = Console.ReadLine();

            return z;
        }
    }
}
