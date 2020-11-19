using System;
using System.Linq;

namespace _01.Reverrse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!="end")
            {
                string reverse = string.Empty;

                for (int i = input.Length-1; i >= 0; i--)
                {
                    reverse += input[i];
                }

                Console.WriteLine($"{input} = {reverse}");

                input = Console.ReadLine();
            }
        }
    }
}