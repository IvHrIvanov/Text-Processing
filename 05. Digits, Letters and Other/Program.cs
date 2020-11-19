using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();


            string[] output = new string[3];

            foreach (var item in text)
            {
                if (char.IsDigit(item))
                {
                    output[0] += item;

                }
                else if (char.IsLetter(item))
                {
                    output[1] += item;
                }
                else if (char.IsSymbol(item) || char.IsPunctuation(item))
                {
                    output[2] += item;
                }

            }

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
