using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Program
    {
        public static void Run()
        {
            var Number = 0;
            var Guess = 0;
            var Wrong = 0;
            var seed = DateTime.Now.Millisecond;
            Random rnd = new Random(seed);
            Number = rnd.Next(100) + 1;
            Console.WriteLine("You have 10 tries to Guess the Number.");
            Console.Write("Enter a Number Between 1-100 : ");
            var Answer = Console.ReadLine();
            var AnswerAsNumber = int.Parse(Answer);
            {
                while (AnswerAsNumber != Number)
                {
                    if (AnswerAsNumber < 1 || AnswerAsNumber > 100)
                    {
                        Console.Write("Number MUST be between 1-100. ");
                        Console.Write("Enter a Number: ");
                        Answer = Console.ReadLine();
                        AnswerAsNumber = int.Parse(Answer);
                        ++Wrong;
                        continue;
                    }
                    if (AnswerAsNumber < Number)
                    {
                        Console.Write("Guess Too Low ");
                        ++Guess;
                    }
                    else
                    {
                        Console.Write("Guess Too High ");
                        ++Guess;
                    }
                    if (Guess == 10)
                    {
                        Console.WriteLine("To many guesses try again.");
                        Console.WriteLine($"The Number was {Number}");
                        Restart();
                        Console.ReadKey();
                    }
                    if (Wrong == 5)
                    {
                        Console.WriteLine($"You have input Numbers out side of bounds {Wrong} times.");
                        Console.WriteLine("GAME OVER");
                        Restart();
                        Console.ReadKey();
                    }
                    Console.Write(":");
                    Answer = Console.ReadLine();
                    AnswerAsNumber = int.Parse(Answer);
                    //++Guess;
                }
                if (AnswerAsNumber == Number)
                {
                    Console.WriteLine("Congratulations you guessed Correctly.");
                    Restart();
                    Console.ReadKey();
                }
                /* If you fail and want to play again enter Y, if not enter N.
                 * If Y start game again
                 * If N break out of program.
                */
            }
        }

        public static void Restart()
        {
            Console.WriteLine("Would You Like To Play Again?"
            + " N to Quit, or Y to Play Again");
            string restar = Console.ReadLine();
            if (restar.ToUpper() == "Y")
            {
                Run();
            }
            else
            {
                return;
            }
        }

        static void Main(string[] args)
        {
            Run();

        }
    }
}