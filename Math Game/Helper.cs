using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math_Game;
using Math_Game.Model;
namespace Math_Game
{

    internal class Helper
    {
        internal static List<Game> games = new List<Game>() 
        {
        //new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
        //new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
        //new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
        //new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
        //new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
        //new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
        //new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
        //new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
        //new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
        //new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
        //new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
        //new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
        //new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },   
        };
        internal static string GetName(string name)
        {
            Console.WriteLine("Enter your name here");
             name = Console.ReadLine();

            while(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid input. Try again!!!!");
                name = Console.ReadLine();
            }
            return name;
        }
        internal static int[] GetDivision()
        {
            var random = new Random();
            var a = random.Next(1, 9);
            var b = random.Next(1, 9);
            while (a % b != 0)
            {
                a = random.Next(1, 9);
                b = random.Next(1, 9);
            }
            var result = new int[2];
            result[0] = a;
            result[1] = b;

            return result;

        }
        internal static void AddToHistory(int score, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = score,
                Type = gameType
            });
        }
        internal static void PrintGames()
        {

            Console.Clear();
            Console.WriteLine("Game history");
            Console.WriteLine("------------------------\n");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts ");
            }
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadLine();
        }

        internal static string? validateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || Int32.TryParse(result, out _))
            {
                Console.WriteLine("Invalid input. Try again!!!!");
                result = Console.ReadLine();
            }
            return result;
        }
    }
}
