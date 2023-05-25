
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projrct1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scorecpu = 0;
            bool playagain = true;


           while (playagain)
            {

            }

            while (scorePlayer < 3 && scorecpu < 3)
            {

            }

            Console.Write("Chooes between ROCK, PAPER AND SCISSORS: ");
            inputPlayer = Console.ReadLine();
            inputPlayer = inputPlayer.ToUpper();
            Random rnd = new Random();
            randomInt = rnd.Next(1, 4);

            switch (randomInt)
            {

                case 1:
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer choose ROCK");
                    if (inputPlayer == "ROCK")
                    {

                        Console.WriteLine("DRAW!\n\n");
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("PLAYET WINS!! \n\n");
                        scorePlayer++;
                    }

                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("CPU WINS! ! \n\n");
                        scorecpu++;
                    }
                    break;
                case 2:
                    inputCPU = "PAPER";
                    Console.WriteLine("Computer choose ROCK");
                    if (inputPlayer == "ROCK")
                    {

                        Console.WriteLine("DRAW! \n\n");
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("PLAYET WINS ! ! \n\n");
                        scorePlayer++;
                    }

                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("CPU WINS! ! \n\n");
                        scorecpu++;
                    }
                    break;
                case 3:
                    inputCPU = "SCISSORS";
                    Console.WriteLine("Computer choose ROCK");
                    if (inputPlayer == "ROCK")
                    {

                        Console.WriteLine("DRAW! \n\n");
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("PLAYET WINS ! ! \n\n");
                        scorePlayer++;
                    }

                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("CPU WINS! ! \n\n");
                        scorecpu++;
                    }
                    break;
                default:
                    Console.WriteLine("Invalide entry");
                    break;
            }
            if (scorePlayer == 3)
            {
                Console.WriteLine("player won!");
            }

           else if (scorecpu == 3)
            {
                Console.WriteLine("cpu won!");
            }

            else
            {

            }
            Console.WriteLine("Do you want to play again? (y/n)");
            string loop = Console.ReadLine();
            if (loop == "y")
            {
                playagain = true;
            }
            else if (loop == "n")
            {
                playagain = false;
            }
            else
            {

            }



        }




    }
}