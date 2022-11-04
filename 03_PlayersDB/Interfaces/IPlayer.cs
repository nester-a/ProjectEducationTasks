namespace _03_PlayersDB.Interfaces
{
    internal interface IPlayer
    {
        int Id { get; set; }

        string Name { get; set; }

        int Level { get; set; }

        bool IsBanned { get; set; }
    }
}
