using System;
using System.Collections.Generic;


namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The 'Number Guessing Game'");
            Console.WriteLine("Do you wish to play? Answer: Y, N");
            string start = Console.ReadLine();
            var choices = new List<int>();


            if (start != "Y" && start != "N")
            {
                Console.WriteLine("Wrong choices!!!");
                return;
            }
            else if (start == "N")
            {
                Console.WriteLine("Understood. Program closes");
                return;

            }
            else
                Console.WriteLine("Choose lower range value: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose higher range value: ");
            int y = Convert.ToInt32(Console.ReadLine());
            while (x <= y)
            {
                choices.Add(x);
                x++;

            }
            Console.WriteLine("Numbers in the chosen range:");
            choices.ForEach(Console.WriteLine);
            var randomChoice = new Random();
            int index = randomChoice.Next(choices.Count);

            {
                do
                {
                    Console.WriteLine("Choose a number:");
                    int choicePlayer = Convert.ToInt32(Console.ReadLine());
                    if (choicePlayer < choices[index])
                    {
                        Console.WriteLine("Go higher");
                    }
                    else if (choicePlayer > choices[index])
                    {
                        Console.WriteLine("Go Lower");
                    }
                    else if (choicePlayer == choices[index])
                    {
                        Console.WriteLine("You win!!!");
                        return;
                    }

                } while (true);
            }
        }
    }
}
