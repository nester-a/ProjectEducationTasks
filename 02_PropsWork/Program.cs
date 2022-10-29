
using _02_PropsWork.Entities;

var player = new Player();
player.X = 10;
player.Y = 20;

var renderer = new Renderer();
renderer.Render(player);


Console.WriteLine("Work ends");
Console.ReadLine();
