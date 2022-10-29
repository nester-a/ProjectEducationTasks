using _04_CardDeck.Entities;

var deck = new CardDeck(36);
var player = new Player();

player.GetCard(deck);
Console.WriteLine("Next turn");
player.GetCards(deck, 5);

Console.WriteLine("Work ends");
Console.ReadLine();
