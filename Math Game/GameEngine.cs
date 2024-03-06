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
            int a, b;
            int score = 0;
            var random = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Addition mode");
                a = random.Next(1, 9);
                b = random.Next(1, 9);
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
            Helper.AddToHistory(score, GameType.Addition);


        }


        internal void Subtraction(string gamemode)
        {
            int a, b;
            int score = 0;
            var random = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Subtraction mode");
                a = random.Next(1, 9);
                b = random.Next(1, 9);
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
            Helper.AddToHistory(score, GameType.Subtraction);
        }
         internal void Multiplication(string gamemode)
        {
            Console.WriteLine("You choose multiplication mode");
            int a, b;
            int score = 0;
            var random = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Multiplication mode");
                a = random.Next(1, 9);
                b = random.Next(1, 9);
                Console.WriteLine($"{a}+{b}=");
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
            Helper.AddToHistory(score, GameType.Multiplication);
        }
        internal void Division(string gamemode)
        {
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(" Division mode");
                var DivNumber = Helper.GetDivision();
                int a = DivNumber[0];
                int b = DivNumber[1];
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
            Helper.AddToHistory(score, GameType.Division);
        }
        internal void Quit(string gamemode)
        {
            Console.WriteLine("Thank you for playing. Press any key to exit");
            Console.ReadLine();
        }
    }
}
