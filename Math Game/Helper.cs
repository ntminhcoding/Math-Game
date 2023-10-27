using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math_Game;
namespace Math_Game
{

    internal class Helper
    {
        static List<String> games=new();
        internal static string GetName(string name)
        {
            Console.WriteLine("Enter your name here");
             name = Console.ReadLine();
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
        internal static void AddToHistory(int score, string v)
        {
            games.Add($"{DateTime.Now}-{v}: Score={score}");
        }
        internal static void GetGame()
        {
            Console.Clear();
            Console.WriteLine("Game history");
            Console.WriteLine("------------------------\n");
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadLine();
        }
    }
}
