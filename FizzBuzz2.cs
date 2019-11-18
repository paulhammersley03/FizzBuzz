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
            //0-100 Counter
            for (int i = 1; i <= 250; i++)
            //Make String Fizz or Buzz
            {
            //Blank String to Build Up
            string Builder = "";               
                if (i % 3 == 0)
                    Builder += "Fizz";

                if (i % 5 == 0)
                    Builder += "Buzz";

                if (i % 7 == 0)
                    Builder += "Bang";

                if (i % 11 == 0)
                    Builder = "Bong";

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
