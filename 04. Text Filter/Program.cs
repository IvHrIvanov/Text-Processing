using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] bannedWords = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            foreach (var item in bannedWords)
            {
                string replace = new string('*',item.Length);

                text = text.Replace(item, replace);

            }

            Console.WriteLine(text);

        }
    }
}
