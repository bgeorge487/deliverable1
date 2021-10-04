using System;

namespace gcDeliverable1
{
    class Program
    {
        static void Main(string[] args)
        {

            string loop;


            do
            {
                string userInput;
                float unitInput;

                Console.WriteLine("Which unit do you wish to convert?");
                userInput = Console.ReadLine();
                Console.Write("Please provide an amount: ");
                var secondInput = Console.ReadLine();
                unitInput = float.Parse(secondInput);

                switch (userInput)
                {
                    case "inches":
                        Console.WriteLine(unitInput * 3.5 + " fidget spinners");
                        break;
                    case "fidget spinners":
                        Console.WriteLine(unitInput / 3.5 + " inches");
                        break;
                    case "feet":
                        Console.WriteLine(unitInput * 5 + " memes");
                        break;
                    case "memes":
                        Console.WriteLine(unitInput / 5 + " feet");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Would you like to do another conversion? (y/n)");
                loop = Console.ReadLine();

            } while (loop == "y");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //do
            //{

            //} while (userInput == "y");

            // condition = either true or false for example: userInput == "memes" OR UnitInput <= 2, And operator = &&, Or operator = ||

        }
    }
}
