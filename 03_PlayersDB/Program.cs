using _03_PlayersDB.Entities;
using Services;

var factory = new PlayerFactory();
var players = factory.CreatePlayers(100);

var db = new DataBase();
db.AddPlayers(players);



Console.WriteLine("Программа выполнена");
Console.ReadLine();
