using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class Iteration
    {

        public void RepeatTenTimes()
        {
            Console.WriteLine("Input upprepa tio gånger");
            string input = Console.ReadLine();

            //input validation
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Ingen input. Försök igen.");
                return; 
            }


            //Repeat ten times

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}.{input}, ");
            }
            Console.WriteLine();
        }

    }
}
