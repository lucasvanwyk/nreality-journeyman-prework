using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FizzBuzz;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                var result = Translator.Translate(i);
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
