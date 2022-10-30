namespace _03_PlayersDB.Interfaces
{
    internal interface IPlayer
    {
        int Id { get; set; }//Пустые строки меж методами
        string Name { get; }
        int Level { get; }
        bool IsBanned { get; set; }
    }
}
