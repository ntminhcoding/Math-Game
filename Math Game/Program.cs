// See https://aka.ms/new-console-template for more information
using Math_Game;


Console.WriteLine("Welcome the the MATH GAME");
Console.WriteLine("__________________________");
var date = DateTime.UtcNow;
List<String> games = new List<String>();
var Menu = new Menu();
string name="";
Helper.GetName(name);
Menu.ShowMenu(name, date);



