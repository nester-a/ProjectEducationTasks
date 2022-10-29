namespace _03_PlayersDB.Interfaces
{
    internal interface IPlayer
    {
        int Id { get; set; }
        string Name { get; }
        int Level { get; }
        bool IsBanned { get; set; }
    }
}
