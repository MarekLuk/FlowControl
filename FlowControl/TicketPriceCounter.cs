﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class TicketPriceCounter
    {
        public void CalculatePrice()
        {
            Console.WriteLine("Antal personer:");

            int numberPerson;
            //Parsing  input, 
            bool successParse = int.TryParse(Console.ReadLine(), out numberPerson);

            //Check if parsing successful 

            if (!successParse || numberPerson < 1)
            {
                Console.WriteLine("Felaktig input,Ange ett giltigt antal personer ");
            }
            else
            {
                int totalCost = 0;

                for (int i = 0; i < numberPerson; i++)
                {
                    bool validAge;
                    int age;
                    //input validation
                    do
                    {
                        Console.WriteLine($"Personens ålder nr {i + 1}:");
                        validAge = int.TryParse(Console.ReadLine(), out age);

                        if (!validAge || age < 0 || age > 150)
                        {
                            Console.WriteLine("Ogiltig ålder input. Åldern måste vara ett nummer mellan 0 och 150. Försök igen.");
                            validAge = false;
                        }
                    }
                    while (!validAge);

                    //checking age and define price

                        if (age < 18)
                        {
                            Console.WriteLine("Ungdomspris: 80kr");
                            totalCost += 80;
                        }
                        else if (age > 64 && age <= 100)
                        {
                            Console.WriteLine("Pensionärspris: 90kr");
                            totalCost += 90;
                        }
                        else if (age < 5)
                        {
                            Console.WriteLine("Barn under 5 år: gratis");
                        }

                        else if (age > 100)
                        {
                            Console.WriteLine("Över 100 år: gratis");
                        }

                        else
                        {
                            Console.WriteLine("Standardpris: 120kr");
                            totalCost += 120;
                        }
                    }
                    //print results

                    Console.WriteLine($"Antal personer: {numberPerson}");
                    Console.WriteLine($"Total kostnad : {totalCost}");
                }
            }
        }
    }


