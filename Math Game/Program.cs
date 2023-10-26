// See https://aka.ms/new-console-template for more information
using static System.Formats.Asn1.AsnWriter;

Console.WriteLine("Welcome the the MATH GAME");
Console.WriteLine("__________________________");
var date = DateTime.UtcNow;
string name = GetName();
List<String> games = new List<String>();

Menu(name);
void Addition()
{
    int a, b;
    int score = 0;
    var random= new Random();
    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine("Addition mode");
        a = random.Next(1,9);
        b = random.Next(1,9);
        Console.WriteLine($"{a}+{b}=");
        var result=Console.ReadLine();
        if(int.Parse(result) == a + b)
        {
            Console.WriteLine("You are correct. Press any key to continue");
            score++;
            Console.ReadLine();
        }
        else {
            Console.WriteLine("You are incorrect. Press any key to continue");
            Console.ReadLine();
        }
    }
    
    Console.WriteLine("your total score is:" + score + ". Press any key to return to the menu");
    Console.ReadLine();
    AddToHistory(score, "Addition");
    

}

void AddToHistory(int score, string v)
{
    games.Add($"{DateTime.Now}-{v}: Score={score}");
}

void Subtraction()
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
    AddToHistory(score, "Subtraction");
}
void Multiplication()
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
    AddToHistory(score, "Multiplication");
}
void Division()
{
    int score = 0;
    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(" Division mode");
        var DivNumber = GetDivision();
        int a = DivNumber[0];
        int b = DivNumber[1];
        Console.WriteLine($"{a}/{b}=");
        var result = Console.ReadLine();
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
    Console.WriteLine("your total score is:" + score+". Press any key to return to the menu");
    Console.ReadLine();
    AddToHistory(score, "Division");
}
void Quit()
{
    Console.WriteLine("Thank you for playing. Press any key to exit");
    Console.ReadLine();
}

void Menu(string? name)
{  
    Console.WriteLine("Welcome " + name + ".Now is "+date+". This is the math game");
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
                GetGame();
                break;
            case "a":
                Addition();
                break;
            case "s":
                Subtraction();
                break;
            case "m":
                Multiplication();
                break;
            case "d":
                Division();
                break;
            case "q":
                Quit();
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Sorry but that is not a valid option");
                Environment.Exit(0);
                break;
        }
    } while (IsGameOn);
}

void GetGame()
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

static string GetName()
{
    Console.WriteLine("Enter your name here");
    var name = Console.ReadLine();
    return name;
}
int[] GetDivision()
{
    var random= new Random();
    var a= random.Next(1, 9);
    var b= random.Next(1, 9);
    while (a % b != 0)
    {
        a= random.Next(1, 9);
        b= random.Next(1, 9);
    }
    var result= new int[2];
    result[0] = a; 
    result[1] = b;
    
    return result;

}