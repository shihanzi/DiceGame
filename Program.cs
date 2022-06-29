using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRoll;
            int opponantAI;
            int resultOfPlayerOne = 0;
            int resultOfOpponent = 0;
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nPress Any Key to Roll the Dice");
                Console.ReadKey();
                playerRoll = random.Next(1, 7);
                Console.WriteLine("Player number" + playerRoll);
                Console.WriteLine(".....");
                System.Threading.Thread.Sleep(2000);
                opponantAI = random.Next(1, 7);   
                Console.WriteLine("Opponent number" + opponantAI);
                resultOfPlayerOne += playerRoll;
                resultOfOpponent += opponantAI;


            }
            Console.WriteLine("Total Points of You:" + resultOfPlayerOne);
            Console.WriteLine("Total Points of Opponent:" + resultOfOpponent);
            if (resultOfOpponent>resultOfPlayerOne)
            {
                Console.WriteLine("Opponent Won the Game");
            }
            else if (resultOfOpponent < resultOfPlayerOne)
            {
                Console.WriteLine("You Won the Game");
            }
            else
            {
                Console.WriteLine("Game Drawn");
            }
        }
    }
}
