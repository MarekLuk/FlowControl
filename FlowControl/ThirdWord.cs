using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class ThirdWord
    {


        public void SplitWords()
        {
            string inputSentence;
            string[] splitedSentence = Array.Empty<string>();

            do
            {
                Console.WriteLine("Anger en mening med minst 3 ord:");
                inputSentence = Console.ReadLine();

                // Validate input 
                if (string.IsNullOrEmpty(inputSentence))
                {
                    Console.WriteLine("Ingen input. Försök igen.");
                   
                }
                else
                {
                    // Split sentence
                    splitedSentence = inputSentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    // Check if it's minimum 3 words
                    if (splitedSentence.Length < 3)
                    {
                        Console.WriteLine("Meningen måste innehålla minst 3 ord. Försök igen.");
                    }
                }

            } while (string.IsNullOrEmpty(inputSentence) || splitedSentence.Length < 3);

            Console.WriteLine($"Tredje ord är: {splitedSentence[2]}");


        }
    }
}


