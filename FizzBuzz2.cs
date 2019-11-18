using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizz_buzz
{
    class FizzBuzz
    {
        static void Main()
        {
            for (int i = 1; i <= 250; i++)
            {
                string Builder = "";               
                if (i % 3 == 0)
                    Builder += "Fizz";
                if (i % 5 == 0)
                    Builder += "Buzz";
                if (i % 7 == 0)
                    Builder += "Bang";
                if (i % 11 == 0)
                    Builder = "Bong";               
                if (i % 13 == 0)
                    Builder = "Fezz";
                    string[] Split = Builder.Split('B');
                    foreach (var word in Split)
                    if (Builder.Length > 0)
                    Console.WriteLine(Builder);
                else Console.WriteLine(i);                               
            }
            {                
                Console.ReadLine();
            }
        }
    }
}
