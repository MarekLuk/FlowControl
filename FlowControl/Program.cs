namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            bool isProgramActive = true;

            //create instance of class

            TicketPriceCounter ticketPriceCounter = new TicketPriceCounter();
            Iteration iteration = new Iteration();
            ThirdWord thirdWord = new ThirdWord();

            // create itreation until user cllick "0" then  isProgramActive = false;
            while (isProgramActive)
            {
                //print menu
                Console.WriteLine("Välkommen! \nMenu:");
                Console.WriteLine("0: Utgång");
                Console.WriteLine("1: Biljettkostnad");
                Console.WriteLine("2: Iteration");
                Console.WriteLine("3: Plocka ut tredje ordet");


                
                //read input and simply validation


                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input)) 
                    {
                    Console.WriteLine("Input kan inte vara tom. Försök igen");
                }

                //when input is not null or empty switch between cases
                else
                {

                    switch (input)
                    {
                        case "X":
                            isProgramActive = false;
                            break;
                        case "1":
                            ticketPriceCounter.CalculatePrice();
                            break;
                        case "2":
                            iteration.RepeatTenTimes();
                            break;
                        case "3":
                            thirdWord.SplitWords();
                            break;
                        default:
                            Console.WriteLine("Felaktig input");
                            break;

                    }
                }
            }                                             
        }
    }
}
