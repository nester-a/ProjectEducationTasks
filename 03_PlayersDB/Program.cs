using _03_PlayersDB.Entities;
using Services;

var factory = new PlayerFactory();
var players = factory.CreatePlayers(100);
var printer = new ConsolePrinter();
var db = new DataBase();
db.AddPlayers(players);

db.BanPlayer(11);

printer.Print(db);

Console.WriteLine("Программа выполнена");
Console.ReadLine();
