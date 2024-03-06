
using Math_Game;
namespace Math_Game
{
    internal class Menu
    {
        GameEngine GameEngine=new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine("Welcome " + name + ".Now is " + date + ". This is the math game");
            Console.WriteLine("Press any key to show menu");
            Console.ReadLine();
            Console.WriteLine("\n");
            var IsGameOn = true;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"What do you want to play today? Choose from the options below:
v: View previous game
A: Addition
S: Subtraction
M: Multiplication
D: Division
Q: Quit the game");
                Console.WriteLine("\n");
                var option = Console.ReadLine();
                option = option.Trim().ToLower();

                switch (option)
                {
                    case "v":
                        Helper.PrintGames();
                        break;
                    case "a":
                            GameEngine.Addition("Addition");
                        break;
                    case "s":
                        GameEngine.Subtraction("Subtraction");
                        break;
                    case "m":
                        GameEngine.Multiplication("Multiplication");
                        break;
                    case "d":
                        GameEngine.Division("Division");
                        break;
                    case "q":
                        GameEngine.Quit("Quit");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Sorry but that is not a valid option");
                        Environment.Exit(0);
                        break;
                }
            } while (IsGameOn);
        }
    }
}
