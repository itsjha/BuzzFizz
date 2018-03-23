using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuzzFizz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
                Console.WriteLine((i % 3 == 0) ? "Buzz" + ((i % 5 == 0) ? "Fizz" : "") : (i % 5 == 0) ? "Fizz" : i + "");
            Console.ReadKey();
        }
    }
}
