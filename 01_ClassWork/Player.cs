namespace _01_ClassWork
{
    internal class Player : IPlayer
    {
        private readonly string _name;

        public Player(string name)
        {
            _name = name;
        } //Пропущена пустая строка после метода (закрывающей скобки).
        public void PrintInfo()
        {
            Console.WriteLine($"Player {_name}");
        }
    }
}
