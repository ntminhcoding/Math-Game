using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math_Game.Model;
namespace Math_Game
{
    internal class GameEngine
    {
       internal void Addition(string gamemode)
        {
            Console.Clear();
            int score = 0;
            (string choice, GameLevel level) = Helper.difficultySelect();
            for (int i = 0; i < 5; i++)
            {
                (int a, int b) = Helper.difficultySeed(choice);
                Console.Clear();
                Console.WriteLine("Addition mode");
                Console.WriteLine($"{a}+{b}=");
                var result = Console.ReadLine();
                result = Helper.validateResult(result);
               
                if (int.Parse(result) == a + b)
                {
                    Console.WriteLine("You are correct. Press any key to continue");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You are incorrect. Press any key to continue");
                    Console.ReadLine();
                }
            }

            Console.WriteLine("your total score is:" + score + ". Press any key to return to the menu");
            Console.ReadLine();
            Helper.AddToHistory(score, GameType.Addition, level);


        }


        internal void Subtraction(string gamemode)
        {
            Console.Clear();
            int score = 0;
            (string choice, GameLevel level) = Helper.difficultySelect();
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                (int a, int b) = Helper.difficultySeed(choice);
                Console.WriteLine("Subtraction mode");
                Console.WriteLine($"{a}-{b}=");
                var result = Console.ReadLine();
                result = Helper.validateResult(result);
                if (int.Parse(result) == a - b)
                {
                    Console.WriteLine("You are correct. Press any key to continue");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You are incorrect. Press any key to continue");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("your total score is:" + score + ". Press any key to return to the menu");
            Console.ReadLine();
            Helper.AddToHistory(score, GameType.Subtraction, level);
        }
         internal void Multiplication(string gamemode)
        {
            Console.Clear();
            int score = 0;
            (string choice, GameLevel level) = Helper.difficultySelect();
            var random = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Multiplication mode");
                (int a, int b) = Helper.difficultySeed(choice);
                Console.WriteLine($"{a}*{b}=");
                var result = Console.ReadLine();
                result = Helper.validateResult(result);
                if (int.Parse(result) == a * b)
                {
                    Console.WriteLine("You are correct. Press any key to continue");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You are incorrect. Press any key to continue");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("your total score is:" + score + ". Press any key to return to the menu");
            Console.ReadLine();
            Helper.AddToHistory(score, GameType.Multiplication, level);
        }
        internal void Division(string gamemode)
        {
            Console.Clear();
            int score = 0;
            (string choice, GameLevel level) = Helper.difficultySelect();
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(" Division mode");
                (int a, int b) = Helper.difficultySeed(choice);
                while (a % b != 0)
                {
                    (a, b) = Helper.difficultySeed(choice);
                }
                Console.WriteLine($"{a}/{b}=");
                var result = Console.ReadLine();
                result = Helper.validateResult(result);
                if (int.Parse(result) == a / b)
                {
                    Console.WriteLine("You are correct. Press any key to continue");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You are incorrect. Press any key to continue");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("your total score is:" + score + ". Press any key to return to the menu");
            Console.ReadLine();
            Helper.AddToHistory(score, GameType.Division, level);
        }
        internal void Quit(string gamemode)
        {
            Console.WriteLine("Thank you for playing. Press any key to exit");
            Console.ReadLine();
        }
    }
}
