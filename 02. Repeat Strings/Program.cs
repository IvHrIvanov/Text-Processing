using System;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {

                string currentWord = input[i];

                for (int a = 0; a < input[i].Length; a++)
                {
                    output += currentWord;
                  
                }

            }

            Console.WriteLine(output);

        }
    }
}